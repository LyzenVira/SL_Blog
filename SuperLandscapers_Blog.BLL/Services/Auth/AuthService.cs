using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using Azure.Core;
using BLL.DTOs.Exceptions;
using BLL.DTOs.Response;
using BLL.Models;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly UserManager<DAL.Entities.Customer> _userManager;
    private readonly SignInManager<DAL.Entities.Customer> _signInManager;
    private readonly RoleManager<IdentityRole<Guid>> _roleManager;
    private readonly IMapper _mapper;
    private readonly JwtOptions _options;
    private static readonly Random random = new Random();


    public AuthService(UserManager<DAL.Entities.Customer> userManager, SignInManager<DAL.Entities.Customer> signInManager, RoleManager<IdentityRole<Guid>> roleManager, IMapper mapper, JwtOptions options)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _mapper = mapper;
        _options = options;
    }

    public async Task<ResponseEntity<SignInResponse>> SignInAsync(SignInModel model)
    {
        var customer = await _userManager.Users.FirstOrDefaultAsync(user => user.Email == model.Email);

        if (customer is null)
        {
            throw new NotFoundException("The user doesn't exist");
        }

        var validPassword = await _signInManager.CheckPasswordSignInAsync(customer, model.Password, false);

        if (!validPassword.Succeeded)
        {
            throw new NotFoundException("Passwords don't match");
        }

        var accessToken = JwtService.JwtService.GenerateAccessToken(_options, await GenerateClaimsIdentityAsync(customer));
        var refreshToken = JwtService.JwtService.GenerateRefreshToken(_options);

        return new ResponseEntity<SignInResponse>(HttpStatusCode.Created, new SignInResponse() { AccessToken = accessToken, RefreshToken = refreshToken });
    }

    public async Task<ResponseEntity<SignInResponse>> SignUpAsync(SignUpModel model)
    {
        var customer = await _userManager.Users.FirstOrDefaultAsync(user => user.Email == model.Email || user.PhoneNumber == model.PhoneNumber);

        if (customer is not null)
        {
            throw new ValidationException("The user with such credentials already exist");
        }

        var entity = _mapper.Map<DAL.Entities.Customer>(model);
        var result1 = await _userManager.CreateAsync(entity, model.Password);
        if (!result1.Succeeded)
        {
            throw new ValidationException(result1.Errors.Select(error => error.Description));
        }
        if (!await _roleManager.RoleExistsAsync(model.Role))
        {
            var result2 = await _userManager.AddToRoleAsync(entity, model.Role);
            if (!result2.Succeeded)
            {
                throw new ValidationException(result2.Errors.Select(error => error.Description));
            }
        }
        var accessToken = JwtService.JwtService.GenerateAccessToken(_options, await GenerateClaimsIdentityAsync(entity));
        var refreshToken = JwtService.JwtService.GenerateRefreshToken(_options);

        return new ResponseEntity<SignInResponse>(HttpStatusCode.Created, new SignInResponse() { AccessToken = accessToken, RefreshToken = refreshToken });
    }

    private async Task<ClaimsIdentity> GenerateClaimsIdentityAsync(DAL.Entities.Customer customer)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, customer.UserName),
            new Claim(ClaimTypes.Email, customer.Email),
            new Claim("Id", customer.Id.ToString())
        };

        var roles = await _userManager.GetRolesAsync(customer);
        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        return new ClaimsIdentity(claims);
    }
    public async Task<ResponseEntity> ChangePassword(SignInModel model)
    {
        var customer = await _userManager.Users.FirstOrDefaultAsync(user => user.Email == model.Email);

        if (customer is null)
        {
            throw new NotFoundException("The user doesn't exist");
        }

        var accessToken = JwtService.JwtService.GenerateAccessToken(_options, await GenerateClaimsIdentityAsync(customer));
        var refreshToken = JwtService.JwtService.GenerateRefreshToken(_options);

        return new ResponseEntity<SignInResponse>(HttpStatusCode.Created, new SignInResponse() { AccessToken = accessToken, RefreshToken = refreshToken });
    }
}