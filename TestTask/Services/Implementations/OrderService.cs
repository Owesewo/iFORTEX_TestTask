using TestTask.Data;
using Microsoft.EntityFrameworkCore;
using TestTask.Models;
using TestTask.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace TestTask.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderService(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public Task<Order> GetOrder() =>
            _dbContext.Orders.OrderByDescending(o => o.Price).FirstAsync();

        public Task<List<Order>> GetOrders() =>
            _dbContext.Orders.Where(o => o.Quantity > 10).ToListAsync();
    }
}
