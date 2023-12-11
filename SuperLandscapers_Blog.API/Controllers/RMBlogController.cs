
using BLL.DTOs.OrderBlogDTO;
using BLL.Services.OrderBlog;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperLandscapers_Blog.API.Model;

namespace SuperLandscapers_Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RMBlogController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IOrderBlogService _orderBlogService;
        public RMBlogController(IPublishEndpoint publishEndpoint, IOrderBlogService orderBlogService)
        {
            _publishEndpoint = publishEndpoint;
            _orderBlogService = orderBlogService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(InsertOrderBlogDTO orderDto)
        {
            await _publishEndpoint.Publish<OrderCreated>(new
            {
                orderDto.Username,
                orderDto.Email,
                orderDto.ShortDescription
            });

            await _orderBlogService.InsertOrderBlogAsync(orderDto);

            return Ok();
        }
    }
}
