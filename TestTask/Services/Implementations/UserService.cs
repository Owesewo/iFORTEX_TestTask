using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementations
{
    public class UserService : IUserService
    {
        public async Task<User> GetUser()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IfortexTestTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                    .Options;
            var db = new ApplicationDbContext(options);

            return await db.Users.FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetUsers()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IfortexTestTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                    .Options;
            var db = new ApplicationDbContext(options);

            return await db.Users.ToListAsync();
        }
    }
}
