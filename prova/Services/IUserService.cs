using prova.Repositories;
using prova.Models;

namespace prova.Services
{
    public interface IUserService
    {
        Task<User> GetUserInfo();
        Task<User> UpdateUserInfo(User user);
    }
}