using Microsoft.EntityFrameworkCore;
using Users.Service.Entities;

namespace Users.Service.Database;

public class UserStorage : IUserStorage
{
    private readonly AppDbContext _appDbContext;

    public UserStorage(AppDbContext context)
    {
        _appDbContext = context;
    }


    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await _appDbContext.Users
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<int> AddAsync(User user)
    {
        await _appDbContext.Users.AddAsync(user);
        await _appDbContext.SaveChangesAsync();

        return user.Id;
    }

    public async Task<User?> GetUserByUsername(string userName)
    {
        var user = await _appDbContext.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.UserName == userName);

        return user;
    }

    public async Task<User?> GetUserById(int id)
    {
        var user = await _appDbContext.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.Id == id);

        return user;
    }
}