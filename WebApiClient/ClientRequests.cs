using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApiClient
{
    public static class ClientRequests
    {
        public static async Task<string> Get(User user, HttpRequestMessage request)
        {
            var response = user.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }
            else
                return $"Server error";
        }

        public static HttpRequestMessage AuthorizationRequestConstruct(User user, string uri)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri($"{uri}"),
                Method = HttpMethod.Get,
            };
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", $"{user.login}&&{user.password}");
            return request;
        }

        public static async Task<string> Post(User user, HttpRequestMessage request)
        {
            var response = user.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }
            else
                return $"Server error";
        }

        public static HttpRequestMessage AddNewUserRequestConstruct(User user, string uri)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri($"{uri}"),
                Method = HttpMethod.Post,
                Content = new StringContent(
                    $"{{\"login\":\"{user.login}\", \"name\":\"{user.login}\", \"surname\":\"{user.login}\", \"id\":\"{Guid.NewGuid().ToString()}\"}}",
                    Encoding.UTF8,
                    "application/json")
            };
            return request;
        }
    }
}