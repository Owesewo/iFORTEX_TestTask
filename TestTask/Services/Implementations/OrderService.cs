using TestTask.Data;
using Microsoft.EntityFrameworkCore;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementations
{
    public class OrderService : IOrderService
    {
        public async Task<Order> GetOrder()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IfortexTestTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                    .Options;
            var db = new ApplicationDbContext(options);
            
            return await db.Orders.FirstOrDefaultAsync();
        }

        public async Task<List<Order>> GetOrders()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IfortexTestTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                    .Options;
            var db = new ApplicationDbContext(options);

            return await db.Orders.ToListAsync();
        }
    }
}
