using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorbisHotDog.Model;
using NorbisHotDog.Repository;

namespace NorbisHotDog.Service
{
    public class UserDataService
    {
        private static UserRepository _userRepository=new UserRepository();

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public User GetUserById(string hotDogId)
        {
            return _userRepository.GetUserById(hotDogId);
        }
        public bool ValidUser(string username, string password)
        {
            return _userRepository.ValidUser(username,password);
        }
    }
}
