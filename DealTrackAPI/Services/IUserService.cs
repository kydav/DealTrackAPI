using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int userId);
        void CreateUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
    }
}
