using DAL.Context;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using DAL.WrapperRepository.Interface;


namespace DAL.WrapperRepository
{
    public class WrapperRepository : IWrapperRepository

    {
        private readonly DataContext _context;

        private IOrderProjectRepository? _orderProjectRepository;
        private IOrderBlogRepository? _orderBlogRepository;
        private IOrderProjectStatusRepository? _orderProjectStatusRepository;
        private IPeriodProgressRepository? _periodProgressRepository;
        private IServiceRepository? _serviceRepository;

        public WrapperRepository(DataContext context)
        {
            _context = context;
        }

        public IServiceRepository ServiceRepository
        {
            get
            {
                if (_periodProgressRepository == null)
                {
                    _serviceRepository = new ServiceRepository(_context);
                }
                return _serviceRepository;
            }
        }

        public IPeriodProgressRepository PeriodProgressRepository
        {
            get
            {
                if (_periodProgressRepository == null)
                {
                    _periodProgressRepository = new PeriodProgressRepository(_context);
                }
                return _periodProgressRepository;
            }
        }

        public IOrderProjectStatusRepository OrderProjectStatusRepository
        {
            get
            {
                if (_orderProjectStatusRepository == null)
                {
                    _orderProjectStatusRepository = new OrderProjectStatusRepository(_context);
                }
                return _orderProjectStatusRepository;
            }
        }

        public IOrderBlogRepository OrderBlogRepository
        {
            get
            {
                if (_orderBlogRepository == null)
                {
                    _orderBlogRepository = new OrderBlogRepository(_context);
                }
                return _orderBlogRepository;
            }
        }

        public IOrderProjectRepository OrderProjectRepository
        {
            get
            {
                if (_orderProjectRepository == null)
                {
                    _orderProjectRepository = new OrderProjectRepository(_context);
                }
                return _orderProjectRepository;
            }
        }
                

        public async Task<int> Save() => await _context.SaveChangesAsync();
    }
}
