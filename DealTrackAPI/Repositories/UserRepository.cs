using System;
using System.Collections.Generic;
using DealTrackAPI.Models;

namespace DealTrackAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public void CreateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
