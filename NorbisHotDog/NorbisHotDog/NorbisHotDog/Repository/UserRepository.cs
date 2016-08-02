using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using NorbisHotDog.Model;

namespace NorbisHotDog.Repository
{
    class UserRepository
    {
        private List<User> _users;
        private MobileServiceClient client;
        private string url = "http://192.168.0.8/NorbisHotDog/";
        public UserRepository()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }
        private async Task LoadDataAsync(string uri)
        {
            client = new MobileServiceClient(uri);
            var users = await client.GetTable<User>().ReadAsync();
            _users = users.ToList();

        }
        public List<User> GetAllUsers()
        {
            return _users;
        }
        public User GetUserById(string userId)
        {
            return _users.Where(c => c.Id == userId).FirstOrDefault();
        }

        public bool ValidUser(string username, string password)
        {
            return _users.Where(c => c.UserName == username && c.Password == password).Any();
        }
    }
}
