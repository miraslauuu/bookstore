using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Data.Repositories
{
    public interface IOrderDetailRepository
    {
        Task<IEnumerable<OrderDetail>> GetAllOrderDetails();
        Task<OrderDetail> GetOrderDetailById(int orderDetailId);
        Task AddOrderDetail(OrderDetail orderDetail);
        Task UpdateOrderDetail(OrderDetail orderDetail);
        Task DeleteOrderDetail(int orderDetailId);
    }
}
