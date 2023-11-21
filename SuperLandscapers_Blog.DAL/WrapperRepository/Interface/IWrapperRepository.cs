using DAL.Repositories.Interfaces;

namespace DAL.WrapperRepository.Interface
{
    public  interface IWrapperRepository
    {
        Task<int> Save();

        IOrderBlogRepository OrderBlogRepository { get; }
        IOrderProjectRepository OrderProjectRepository { get; }
        IOrderProjectStatusRepository OrderProjectStatusRepository { get; }
        IPeriodProgressRepository PeriodProgressRepository { get; }
        IServiceRepository ServiceRepository { get; }
    }
}
