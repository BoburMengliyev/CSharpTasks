using ManagementSystemTask.Models.Users;

namespace ManagementSystemTask.Repositories.Users
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int userId);
        Task<User?> GetUserAsync(int userId);
        Task<IEnumerable<User>> GetUsersWithMostTasksAsync(int count = 5);
    }
}
