using ManagementSystemTask.Data;
using ManagementSystemTask.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystemTask.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) =>
            _context = context;

        public async Task<User> AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            User existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser is null)
                throw new KeyNotFoundException($"User with ID {user.Id} not found.");

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            await _context.SaveChangesAsync();

            return existingUser;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            User user = await _context.Users.FindAsync(userId);

            if (user is null)
                return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<User> GetUserAsync(int userId) => 
            await _context.Users.FindAsync(userId);

        public async Task<IEnumerable<User>> GetUsersWithMostTasksAsync(int count = 5) =>
            await _context.Users
                .Include(u => u.Tasks)
                .OrderByDescending(u => u.Tasks.Count)
                .Take(count)
                .AsNoTracking()
                .ToListAsync();
    }
}
