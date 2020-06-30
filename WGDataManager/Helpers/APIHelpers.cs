using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Wolfgang.Models;

namespace Wolfgang.Helpers
{
    public class APIHelpers : IAPIHelpers
    {
        //HttpClient property
        private HttpClient apiClient; 

        //constructor
        public APIHelpers()
        {
            InitializeClient();
        }
        private void InitializeClient()
        {

            string api = ConfigurationManager.AppSettings["api"];
            apiClient = new HttpClient();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

        }

        public async Task<AuthenticateUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type","password"),
                new KeyValuePair<string, string>("username",username),
                new KeyValuePair<string, string>("grant_type",password)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("/Teken", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticateUser>();
                    return result;
                }
                else
                {
                    //why the execution failed
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}