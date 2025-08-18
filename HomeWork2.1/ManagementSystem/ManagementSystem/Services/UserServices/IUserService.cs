using ManagementSystem.Models.Users;

namespace ManagementSystem.Services.UserServices
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int userId);
        Task<User> GetUserAsync(int userId);
        Task<IReadOnlyList<User>> GetUsersWithMostTasksAsync(int topCount);
    }
}
