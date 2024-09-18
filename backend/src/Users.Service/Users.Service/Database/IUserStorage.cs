using Users.Service.Entities;

namespace Users.Service.Database;

public interface IUserStorage
{
    public Task<IEnumerable<User>> GetAllUsers();

    public Task<int> AddAsync(User user);

    public Task<User?> GetUserByUsername(string userName);
}