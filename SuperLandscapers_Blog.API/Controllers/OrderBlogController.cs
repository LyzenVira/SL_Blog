
using BLL.DTOs.OrderBlogDTO;
using BLL.Services.OrderBlog;
using DAL.Enums;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/order-blog")]
    public class OrderBlogController : ControllerBase
    {
        private readonly IOrderBlogService _orderBlogService;

        public OrderBlogController(IOrderBlogService orderBlogService)
        {
            _orderBlogService = orderBlogService;
        }

        /// <summary>
        ///  All informations about orderBlogs 
        /// </summary>
        /// <returns>An ActionResult containing a ResponseEntity with an IEnumerable of GetOrderBlogDTO</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllOrderBlogsAsync()
        {
            var response = await _orderBlogService.GetAllOrderBlogsAsync();
            return Ok(response);
        }
        /// <summary>
        ///  To update type of orderBlog by id
        /// </summary>
        /// <returns>An ActionResult containing a ResponseEntity with an IEnumerable of GetOrderBlogDTO</returns>
        [HttpPut("change-type")]
        public async Task<IActionResult> ChangeTypeOrderAsync(Guid id, bool typeNumber)
        {
            var response = await _orderBlogService.ChangeTypeOrderAsync(id, typeNumber);
            return Ok(response);
        }
        /// <summary>
        /// Information about a specific orderBlog
        /// </summary>
        /// <returns>An ActionResult containing a ResponseEntity with GetOrderBlogDTO</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderBlogByIdAsync(Guid id)
        {
            var response = await _orderBlogService.GetOrderBlogByIdAsync(id);
            return Ok(response);
        }
        /// <summary>
        /// To create an orderBlog
        /// </summary>
        /// <returns>An ActionResult containing a ResponseEntity with GetOrderBlogDTO</returns>
        [HttpPost]
        public async Task<IActionResult> CreateOrderBlogAsync([FromBody] InsertOrderBlogDTO orderBlogDTO)
        {
            var response = await _orderBlogService.InsertOrderBlogAsync(orderBlogDTO);
            return Ok(response);
        }
        /// <summary>
        /// To delete an orderBlog by its Guid
        /// </summary>
        /// <returns>An ActionResult</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderBlogById(Guid id)
        {
            var response = await _orderBlogService.DeleteOrderBlogByIdAsync(id);
            return Ok(response);
        }
        [HttpGet("paged")]
        public async Task<IActionResult> GetPagedOrderBlogsAsync(int page, int pageSize)
        {
            var response = await _orderBlogService.GetPagedOrderBlogsAsync(page, pageSize);
            return Ok(response);
        }

        [HttpGet("filtered")]
        public async Task<IActionResult> GetFilteredOrderBlogsAsync(string username)
        {
            var response = await _orderBlogService.GetFilteredOrderBlogsAsync(username);
            return Ok(response);
        }

        [HttpGet("sorted")]
        public async Task<IActionResult> GetSortedOrderBlogsAsync(string sortBy)
        {
            var response = await _orderBlogService.GetSortedOrderBlogsAsync(sortBy);
            return Ok(response);
        }
    }
}