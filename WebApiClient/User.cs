using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    public class User : HttpClient
    {
        public readonly string login;
        public readonly string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}