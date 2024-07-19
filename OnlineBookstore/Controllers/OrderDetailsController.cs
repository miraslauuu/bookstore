using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Data.Repositories;
using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailsController(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetails()
        {
            var orderDetails = await _orderDetailRepository.GetAllOrderDetails();
            return Ok(orderDetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetail>> GetOrderDetail(int id)
        {
            var orderDetail = await _orderDetailRepository.GetOrderDetailById(id);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return Ok(orderDetail);
        }

        [HttpPost]
        public async Task<ActionResult> AddOrderDetail(OrderDetail orderDetail)
        {
            await _orderDetailRepository.AddOrderDetail(orderDetail);
            return CreatedAtAction(nameof(GetOrderDetail), new { id = orderDetail.OrderDetailID }, orderDetail);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderDetail(int id, OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailID)
            {
                return BadRequest();
            }

            await _orderDetailRepository.UpdateOrderDetail(orderDetail);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            await _orderDetailRepository.DeleteOrderDetail(id);
            return NoContent();
        }
    }
}
