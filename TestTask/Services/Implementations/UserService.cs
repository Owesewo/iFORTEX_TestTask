using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Enums;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public Task<User> GetUser() =>
            _dbContext.Users.OrderBy(u => u.Orders.Count).FirstAsync();

        public Task<List<User>> GetUsers() =>
            _dbContext.Users.Where(u => u.Status == UserStatus.Inactive).ToListAsync();
    }
}
