using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiServer.Models;

namespace WebApiServer.Models
{
    public interface IUserRepository
    {
        void AddUserInBase(User user);
        User FindUserInBase(string ID);
        User RemoveUserInBase(string ID);
        void Update(User user);
        IEnumerable<User> GetAll();
    }
}
