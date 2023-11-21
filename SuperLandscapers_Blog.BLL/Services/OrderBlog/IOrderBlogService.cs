using BLL.DTOs.OrderBlogDTO;
using BLL.DTOs.Response;
using DAL.Enums;

namespace BLL.Services.OrderBlog
{
    public interface IOrderBlogService
    {
        Task<ResponseEntity<IEnumerable<GetOrderBlogDTO>>> GetAllOrderBlogsAsync();
        Task<ResponseEntity<GetOrderBlogDTO>> GetOrderBlogByIdAsync(Guid id);
        Task<ResponseEntity<GetOrderBlogDTO>> InsertOrderBlogAsync(InsertOrderBlogDTO insertOrderBlogDTO);
        Task<ResponseEntity> DeleteOrderBlogByIdAsync(Guid id);
        Task<ResponseEntity<GetOrderBlogDTO>> ChangeTypeOrderAsync(Guid id, bool typeNumber);
        Task<ResponseEntity<IEnumerable<GetOrderBlogDTO>>> GetSortedOrderBlogsAsync(string sortBy);
        Task<ResponseEntity<IEnumerable<GetOrderBlogDTO>>> GetFilteredOrderBlogsAsync(string username);
        Task<ResponseEntity<IEnumerable<GetOrderBlogDTO>>> GetPagedOrderBlogsAsync(int page, int pageSize);
    }
}
