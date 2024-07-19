using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Data.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OnlineBookstoreContext _context;

        public OrderDetailRepository(OnlineBookstoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrderDetails()
        {
            return await _context.OrderDetails.ToListAsync();
        }

        public async Task<OrderDetail> GetOrderDetailById(int orderDetailId)
        {
            return await _context.OrderDetails.FindAsync(orderDetailId);
        }

        public async Task AddOrderDetail(OrderDetail orderDetail)
        {
            await _context.OrderDetails.AddAsync(orderDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderDetail(int orderDetailId)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(orderDetailId);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                await _context.SaveChangesAsync();
            }
        }
    }
}
