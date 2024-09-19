using Users.Service.DTOs.UsersDTO;
using Users.Service.Entities;

namespace Users.Service.Converters;

public static class UserConverter
{
    public static UserInfo ConvertModelToUserInfo(User user)
    {
        var userInfo = new UserInfo()
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            CreationDate = user.CreationDate,
            Role = user.Role.Name,
            Gender = user.Gender,
            Age = user.Age,
            City = user.City
        };

        return userInfo;
    }
}