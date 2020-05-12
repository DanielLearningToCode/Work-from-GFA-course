using ChatApp.Data;
using ChatApp.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ChatApp
{
    public class WebService
    {
        private readonly ApplicationDBContext db;
        private static Uri baseUri = new Uri(Environment.GetEnvironmentVariable("baseUrl"));

        public WebService(ApplicationDBContext db)
        {
            this.db = db;
        }

        public MessagesViewModel GetMessages(int count)
        {
            var url = "api/channel/get-messages";
            string json = SendDataToApi(new { count = count }, url);
            MessagesViewModel viewModel = JsonConvert.DeserializeObject<MessagesViewModel>(json);
            return viewModel;
        }

        public void SendMessage(MessageToSend message)
        {
            var url = "API/MESSAGE";
            SendDataToApi(message, url);
        }

        public void Register(RegisterRequest login)
        {
            var url = "API/USER/REGISTER";
            SendDataToApi(login, url);
        }

        public void Login(LoginRequest login)
        {
            var url = "API/USER/Login";
            var response = SendDataToApi(login, url);
            KeyHolder key = JsonConvert.DeserializeObject<KeyHolder>(response);
            CreateOrUpdateKey(key);
        }

        private void CreateOrUpdateKey(KeyHolder key)
        {
            if (db.KeyHolders.Any())
            {
                var oldOne = db.KeyHolders.ToList().LastOrDefault();
                oldOne.ApiKey = key.ApiKey;
                db.KeyHolders.Update(oldOne);
                db.SaveChanges();
            }
            else
            {
                db.KeyHolders.Add(key);
                db.SaveChanges();
            }
        }

        private KeyHolder ReadKeyFromDb()
        {
            return db.KeyHolders.ToList().LastOrDefault();
        }

        public void LogOut()
        {
            var url = "API/USER/Logout";
            DiscardKey();
            SendDataToApi(null, url);
        }
        private void DiscardKey()
        {
            var key = db.KeyHolders.ToList().LastOrDefault();
            db.KeyHolders.Remove(key);
        }

        private string SendDataToApi(object obj, string url)
        {
            try
            {
                using (HttpClient webClient = new HttpClient())
                {
                    webClient.BaseAddress = baseUri;
                    string textToSend = JsonConvert.SerializeObject(obj);
                    HttpContent content = new StringContent(textToSend, Encoding.UTF8, "application/json");

                    if (ReadKeyFromDb() != null)
                    {
                        webClient.DefaultRequestHeaders.Add("apiKey", ReadKeyFromDb().ApiKey);
                    }
                    HttpResponseMessage responseMessage = webClient.PostAsync(url, content).Result;
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    return json;
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
    }
}

