using ManagementSystem.Data;
using ManagementSystem.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly ManagementSystemDbContext _context;
        public UserService(ManagementSystemDbContext context)
        {
            _context = context;
        }
        public async Task<User> AddUserAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("User name is required.", nameof(user.Name));
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<User> UpdateUserAsync(User user)
        {
            var existing = await _context.Users
                                         .FirstOrDefaultAsync(u => u.Id == user.Id);
            if (existing is null) return null;
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("User name is required.", nameof(user.Name));
            existing.Name = user.Name;
            existing.Email = user.Email;
            await _context.SaveChangesAsync();
            return existing;
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.Users
                                     .FirstOrDefaultAsync(u => u.Id == userId);
            if (user is null) return false;
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<User> GetUserAsync(int userId)
        {
            var user = await _context.Users
                                     .FirstOrDefaultAsync(u => u.Id == userId);
            if (user is null) throw new KeyNotFoundException("User not found.");
            return user;
        }
        public async Task<IReadOnlyList<User>> GetUsersWithMostTasksAsync(int topCount)
        {
            return await _context.Users
                                 .OrderByDescending(u => u.TaskAssignments.Count)
                                 .Take(topCount)
                                 .ToListAsync();
        }
    }
}
