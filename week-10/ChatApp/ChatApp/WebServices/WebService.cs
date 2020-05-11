using ChatApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class WebService
    {
        public static Uri EndPoint = new Uri(Environment.GetEnvironmentVariable("baseUrl"));
        private static string apiKey = string.Empty;

        public async Task<MessagesViewModel> GetMessages()
        {
            var url = "api/channel/get-messages";
            string json = SendDataToApi(new { count = 10 }, url);
            /*try
            {
                using (HttpClient webClient = new HttpClient())
                {
                    webClient.BaseAddress = EndPoint;
                    string content = JsonConvert.SerializeObject(new { count = 10 });
                    webClient.DefaultRequestHeaders.Add("apiKey", "575091af");
                    var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await webClient.PostAsync(url, httpContent); ;
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    var list = JsonConvert.DeserializeObject<MessagesViewModel>(json);
                    return list;
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }*/
            MessagesViewModel model = JsonConvert.DeserializeObject<MessagesViewModel>(json);
            return model;
        }

        public void SendMessage(MessageToSend message)
        {
            var url = "API/MESSAGE";
            SendDataToApi(message, url);

            /* using (HttpClient webClient = new HttpClient())
             {
                 webClient.BaseAddress = EndPoint;
                 var url = "API/MESSAGE";
                 webClient.DefaultRequestHeaders.Add("apiKey", "575091af");
                 string textToSend = JsonConvert.SerializeObject(new { content = message });
                 HttpContent content = new StringContent(textToSend, Encoding.UTF8, "application/json");
                 HttpResponseMessage responseMessage = webClient.PostAsync(url, content).Result;
                 string json = responseMessage.Content.ReadAsStringAsync().Result;
                 Message sentMessage = JsonConvert.DeserializeObject<Message>(json);
                 return sentMessage;
             }*/
        }

        public void Register(RegisterRequest login)
        {
            var url = "API/USER/REGISTER";
            SendDataToApi(login, url);
            /* using (HttpClient webClient = new HttpClient())
             {
                 //webClient.DefaultRequestHeaders.Add("apiKey", "575091af");
                 webClient.BaseAddress = EndPoint;
                 string textToSend = JsonConvert.SerializeObject(login);
                 HttpContent content = new StringContent(textToSend, Encoding.UTF8, "application/json");
                 HttpResponseMessage responseMessage = webClient.PostAsync(url, content).Result;
                 string json = responseMessage.Content.ReadAsStringAsync().Result;
                 RegisterResponse registerResponse = JsonConvert.DeserializeObject<RegisterResponse>(json);
                 return registerResponse;
             }*/
        }

        public void Login(LoginRequest login)
        {
            var url = "API/USER/Login";
            var response = SendDataToApi(login, url);
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response);
            dict.TryGetValue("apiKey", out string key);
            apiKey = key;
        }

        public string SendDataToApi(object obj, string url)
        {
            try
            {
                using (HttpClient webClient = new HttpClient())
                {
                    webClient.BaseAddress = EndPoint;
                    string textToSend = JsonConvert.SerializeObject(obj);
                    HttpContent content = new StringContent(textToSend, Encoding.UTF8, "application/json");
                    if (!string.IsNullOrEmpty(apiKey))
                    {
                        webClient.DefaultRequestHeaders.Add("apiKey", apiKey);
                    }
                    HttpResponseMessage responseMessage = webClient.PostAsync(url, content).Result;
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    return json;
                    //RegisterResponse registerResponse = JsonConvert.DeserializeObject<RegisterResponse>(json);
                    //return registerResponse;
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
    }
}

