using System;
using System.Threading.Tasks;

namespace WebApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter login:");
            var login = Console.ReadLine();
            Console.WriteLine("Enter password:");
            var password = Console.ReadLine();
            
            using var client = new User(login, password);

            var req = ClientRequests.AddNewUserRequestConstruct(client, "http://localhost:5000/client");
            var cont =  await ClientRequests.Post(client, req);
            
            var request = ClientRequests.AuthorizationRequestConstruct(client, "http://localhost:5000/client");
            var content = await ClientRequests.Get(client, request);
            Console.WriteLine(content);
        }
    }
}
