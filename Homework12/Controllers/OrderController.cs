using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework12.Models;

namespace Homework12.Controllers
{
    
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService){
            this.orderService = orderService;
        }
        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            return orderService.getAllOrders();
        }

        // GET: api/Order/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(string id)
        {
            int intID=int.Parse(id);
            var order=orderService.selectbyID(intID);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST: api/Order
        [HttpPost]
        public  ActionResult<Order> AddOrder(Order order)
        {
            try{
                // order.OrderId=int.Parse(Guid.NewGuid().ToString());
                orderService.addOrder(order);
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
           
            return order;
        }   

        // PUT: api/Order/1
        [HttpPut("{id}")]
        public ActionResult<Order> changeOrder(string id, Order order)
        {
            int intId=int.Parse(id);
            if (intId != order.OrderId)
            {
                return BadRequest();
            }
            try{ 
                orderService.changeOrder(order);
            }catch(Exception e){
                string error=e.Message;
                if(e.InnerException!=null) error=e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Order/1
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(string id)
        {
            int intId=int.Parse(id);
            try{ 
                orderService.removeOrder(intId);
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }


}
