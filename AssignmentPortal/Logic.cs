using AssignmentPortal.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPortal
{
    public class Logic
    {
        string uri = "https://localhost:44351/api/Users";
        private static readonly HttpClient client = new HttpClient();

        public async Task<bool> GetUsersAsync()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var test = await reader.ReadToEndAsync();
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> RegisterUserAsync(string email, string password, string identifier)
        {
            var user = new UserObject()
            { 
                Email = email,
                Password = password,
                Identifier = identifier
            };


            var content = JsonConvert.SerializeObject(user);

            var stringContent = new StringContent(content, UnicodeEncoding.UTF8, "application/json"); // use MediaTypeNames.Application.Json in Core 3.0+ and Standard 2.1+

            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var response = await client.PostAsync(uri, stringContent).ConfigureAwait(false); ;

            if (response.StatusCode == HttpStatusCode.Created)
                return true;
            return false;
        }

        public async Task<bool> Login(string email, string password)
        {
            var user = new UserObject()
            {
                Email = email,
                Password = password
            };


            var content = JsonConvert.SerializeObject(user);

            var stringContent = new StringContent(content, UnicodeEncoding.UTF8, "application/json"); // use MediaTypeNames.Application.Json in Core 3.0+ and Standard 2.1+

            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var response = await client.PostAsync("https://localhost:44351/api/Users/Login", stringContent).ConfigureAwait(false); ;

            if (response.StatusCode == HttpStatusCode.OK)
                return true;
            return false;
        }

        public async Task<bool> Submit(Submission submit)
        {
            var content = JsonConvert.SerializeObject(submit);

            var stringContent = new StringContent(content, UnicodeEncoding.UTF8, "application/json"); // use MediaTypeNames.Application.Json in Core 3.0+ and Standard 2.1+

            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var response = await client.PostAsync("https://localhost:44351/api/Submissions", stringContent).ConfigureAwait(false); ;

            if (response.StatusCode == HttpStatusCode.Created)
                return true;
            return false;
        }


        public async Task<string> UsersReport()
        {
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var response = await client.PostAsync("https://localhost:44351/api/Reports/usersReport", null).ConfigureAwait(false); ;

            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<string> SubmissionsReport()
        {
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var response = await client.PostAsync("https://localhost:44351/api/Reports/submissionsReport", null).ConfigureAwait(false); ;

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
