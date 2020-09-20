using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(int userId);
        void CreateUser(UserDTO user);
        void UpdateUser(UserDTO user);
        void DeleteUser(int userId);
    }
}
