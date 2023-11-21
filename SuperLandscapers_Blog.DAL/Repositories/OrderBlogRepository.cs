using DAL.Context;
using DAL.Entities;
using DAL.Enums;
using DAL.GenericRepository;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class OrderBlogRepository : GenericRepository<OrderBlog>, IOrderBlogRepository
    {
        private readonly DataContext _context;
        public OrderBlogRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<OrderBlog> ChangeTypeOrderAsync(OrderBlog orderBlog, bool typeNumber)
        {
            if (typeNumber == true)
            {
                orderBlog.OrderType = Enums.OrderTypeEnum.Accepted;
            }
            else if(typeNumber == false)
            {
                orderBlog.OrderType = Enums.OrderTypeEnum.Rejected;
            }

            _context.Entry(orderBlog).Property(x => x.OrderType).IsModified = true;

            return orderBlog;
        }

        public IEnumerable<OrderBlog> GetPagedOrders(int page, int pageSize)
        {
            return _dbSet.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
        public IEnumerable<OrderBlog> GetFilteredOrders(string username)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrEmpty(username))
                query = query.Where(o => o.Username.Contains(username));

            return query.ToList();
        }
        public IEnumerable<OrderBlog> GetSortedOrders(string sortBy)
        {
            var query = _dbSet.AsQueryable();

            switch (sortBy)
            {
                case "Username":
                    query = query.OrderBy(o => o.Username);
                    break;
                case "Email":
                    query = query.OrderBy(o => o.Email);
                    break;
            }

            return query.ToList();
        }


    }
}
