using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Wolfgang.Helpers
{
    public class APIHelpers
    {
        //HttpClient property
        public HttpClient APIClient { get; set; }

        //constructor
        public APIHelpers()
        {
            InitializeClient();
        }
        private void InitializeClient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

        }

        public async Task Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type","password"),
                new KeyValuePair<string, string>("username",username),
                new KeyValuePair<string, string>("grant_type",password)
            });

            using (HttpResponseMessage response = await APIClient.PostAsync("", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    //var result = await response.Content.ReadAsAsync<AuthenticateUser>();
                }
            }
        }
    }
}