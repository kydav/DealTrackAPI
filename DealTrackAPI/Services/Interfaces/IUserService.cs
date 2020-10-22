using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DealTrackAPI.Models;

namespace DealTrackAPI.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsers();
        Task<UserDTO> GetUser(int userId);
        void CreateUser(UserDTO user);
        void DeleteUser(int userId);
        void UpdateUser(UserDTO user);
    }
}
