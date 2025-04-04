using prova.Models;
using prova.Repositories;
using System.Collections.Generic;

namespace prova.Repositories{


    public class UserRepository : IUserRepository {
        private User _user = new User();
        public Task<User> CreateUser(User user) {
            _user = user;
            return Task.FromResult(_user);
        }
        public Task<User> GetUser() {
            return Task.FromResult(_user);
        }
        public Task<User> UpdateUser(User user) {
                _user = user;
                return Task.FromResult(_user);
        }

    }
}