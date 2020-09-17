using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(int userId);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
