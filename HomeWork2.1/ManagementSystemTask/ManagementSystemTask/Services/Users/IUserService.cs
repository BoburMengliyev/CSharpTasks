using ManagementSystemTask.Models.Users;

namespace ManagementSystemTask.Services.Users
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int userId);
        Task<User?> GetUserAsync(int userId);
        Task<IEnumerable<User>> GetUsersWithMostTasksAsync(int count = 5);
    }
}
