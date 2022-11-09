using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiServer.Models
{
    public class User 
    {
        public string Login { get; }
        public string Surname { get; }
        public string Name { get; }
        public string ID { get; }


        public User(string Login, string Surname, string Name, string ID)
        {
            this.Login = Login;
            this.Surname = Surname;
            this.Name = Name;
            this.ID = ID;
        }
    }
}
