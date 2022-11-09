using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiServer.Models
{
    public class UserRepository : IUserRepository
    {
        private static ConcurrentDictionary<string, User> dataBase;

        public UserRepository()
        {
            var u = new User("c", "c", "c", Guid.NewGuid().ToString());
            dataBase = new ConcurrentDictionary<string, User>();
            dataBase[u.ID] = u;
        }

        public void AddUserInBase(User user)
        {
            dataBase[user.ID] = user;
        }

        public User FindUserInBase(string ID)
        {
            User user;
            dataBase.TryGetValue(ID, out user);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return dataBase.Values;
        }

        public User RemoveUserInBase(string ID)
        {
            User user;
            dataBase.TryRemove(ID, out user);
            return user;
        }

        public void Update(User user)
        {
            dataBase[user.ID] = user;
        }
    }
}
