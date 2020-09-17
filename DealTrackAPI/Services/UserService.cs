using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DealTrackAPI.Models;
using DealTrackAPI.Repositories;

namespace DealTrackAPI.Services
{
    public class UserService : IUserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
        }

        public async Task<User> GetUser(int userId)
        {
            return _userRepository.GetUser(userId);
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
