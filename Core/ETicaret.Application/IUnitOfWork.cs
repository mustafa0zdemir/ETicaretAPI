using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Application.Repositories.ProductRepository;

namespace ETicaretAPI.Application
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerReadRepository CustomerReadRepository { get; }
        ICustomerWriteRepository CustomerWriteRepository { get; }
        IOrderReadRepository OrderReadRepository { get; }
        IOrderWriteRepository OrderWriteRepository { get; }
        IProductReadRepository ProductReadRepository { get; }
        IProductWriteRepository ProductWriteRepository { get; }
        public Task<int> SaveAsync();
    }
}
