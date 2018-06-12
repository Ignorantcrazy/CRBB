using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMissionPlan
{
    public class ApiTools<T>
    {
        public static string ReadAsStringAsync(string apiUrl)
        {
            string baseAddress = GetUrl();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            var response = client.GetAsync(apiUrl);
            return response.Result.Content.ReadAsStringAsync().Result;
        }

        public static T ReadAsObjAsync(string apiUrl)
        {
            string baseAddress = GetUrl();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            var response = client.GetAsync(apiUrl);
            return JsonConvert.DeserializeObject<T>(response.Result.Content.ReadAsStringAsync().Result);
        }

        public static T PostAsync(string apiUrl,int id)
        {
            string baseAddress = GetUrl();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            var requestJson = JsonConvert.SerializeObject("{'ID':" + id + "}");
            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync(apiUrl, httpContent);
            return JsonConvert.DeserializeObject<T>(response.Result.Content.ReadAsStringAsync().Result);
        }

        private static string GetUrl()
        {
            string url = System.Configuration.ConfigurationManager.AppSettings["SafeguardAbility"];
            url = url.Substring(0, url.LastIndexOf('/'));
            string baseAddress = url.Substring(0, url.LastIndexOf('/')+1);
            return baseAddress;
        }
    }
}
