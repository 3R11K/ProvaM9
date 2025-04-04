namespace prova.Repositories
{
    using prova.Models;

    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<User> GetUser();
        Task<User> UpdateUser(User user);

    }
}