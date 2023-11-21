using DAL.Entities;
using DAL.Enums;
using DAL.GenericRepository.Interface;

namespace DAL.Repositories.Interfaces
{
    public interface IOrderBlogRepository : IGenericRepository<OrderBlog>
    {
        public Task<OrderBlog> ChangeTypeOrderAsync(OrderBlog orderBlog, bool typeNumber);
        IEnumerable<OrderBlog> GetPagedOrders(int page, int pageSize);
        IEnumerable<OrderBlog> GetFilteredOrders(string username);
        IEnumerable<OrderBlog> GetSortedOrders(string sortBy);
    }

}
