using OnlineBookstore.Models;
using OnlineBookstore.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrderDetails()
        {
            return await _orderDetailRepository.GetAllOrderDetails();
        }

        public async Task<OrderDetail> GetOrderDetailById(int orderDetailId)
        {
            return await _orderDetailRepository.GetOrderDetailById(orderDetailId);
        }

        public async Task AddOrderDetail(OrderDetail orderDetail)
        {
            await _orderDetailRepository.AddOrderDetail(orderDetail);
        }

        public async Task UpdateOrderDetail(OrderDetail orderDetail)
        {
            await _orderDetailRepository.UpdateOrderDetail(orderDetail);
        }

        public async Task DeleteOrderDetail(int orderDetailId)
        {
            await _orderDetailRepository.DeleteOrderDetail(orderDetailId);
        }
    }
}
