using ManagementSystemTask.Models.Users;
using ManagementSystemTask.Repositories.Users;

namespace ManagementSystemTask.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) =>
            _repository = repository;

        public async Task<User> AddUserAsync(User user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            return await _repository.AddUserAsync(user);
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be greater than zero.");

            return await _repository.DeleteUserAsync(userId);
        }

        public async Task<User> GetUserAsync(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be greater than zero.");

            return await _repository.GetUserAsync(userId);
        }

        public async Task<IEnumerable<User>> GetUsersWithMostTasksAsync(int count = 5)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be greater than zero.");

            return await _repository.GetUsersWithMostTasksAsync(count);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            return await _repository.UpdateUserAsync(user);
        }
    }
}
