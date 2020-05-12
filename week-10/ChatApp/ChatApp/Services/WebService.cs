using ChatApp.Data;
using ChatApp.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

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

        public IndexViewModel GetAllMessages(RequestMessages request)
        {
            string url = "api/channel/get-messages";
            return PostDataToApi<IndexViewModel, RequestMessages>(request, url);
        }

        public void SendMessage(MessageToSend message)
        {
            string url = "API/MESSAGE";
            PostDataToApi<object, MessageToSend>(message, url);
        }

        public void Register(RegisterRequest login)
        {
            string url = "API/USER/REGISTER";
            PostDataToApi<object, RegisterRequest>(login, url);
        }

        public void Login(LoginRequest login)
        {
            string url = "API/USER/Login";
            var key = PostDataToApi<KeyHolder, LoginRequest>(login, url);
            CreateOrUpdateKey(key);
        }

        private KeyHolder ReadKeyFromDb()
        {
            return db.KeyHolders.ToList().LastOrDefault();
        }

        public void LogOut()
        {
            string url = "API/USER/Logout";
            DiscardKey();
            PostDataToApi<object, object>(new object(), url);
        }
        private void DiscardKey()
        {
            var key = db.KeyHolders.ToList().LastOrDefault();
            db.KeyHolders.Remove(key);
        }

        private TResponseType PostDataToApi<TResponseType, TRequestType>(TRequestType input, string url)
        {
            try
            {
                using (HttpClient webClient = new HttpClient())
                {
                    webClient.BaseAddress = baseUri;
                    string textToSend = JsonConvert.SerializeObject(input);
                    HttpContent content = new StringContent(textToSend, Encoding.UTF8, "application/json");
                    if (ReadKeyFromDb() != null)
                    {
                        webClient.DefaultRequestHeaders.Add("apiKey", ReadKeyFromDb().ApiKey);
                    }
                    HttpResponseMessage responseMessage = webClient.PostAsync(url, content).Result;
                    string json = responseMessage.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<TResponseType>(json);
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        public ChannelsViewModel GetChannels()
        {
            string url = "API/CHANNEL/user-channels";
            var channels = GetDataFromApi<Models.Channel[]>(url).ToList();
            return new ChannelsViewModel() { Channels = channels };
        }

        private TReturnType GetDataFromApi<TReturnType>(string url)
        {
            using (HttpClient webClient = new HttpClient())
            {
                webClient.BaseAddress = baseUri;
                if (ReadKeyFromDb() != null)
                {
                    webClient.DefaultRequestHeaders.Add("apiKey", ReadKeyFromDb().ApiKey);
                }
                HttpResponseMessage responseMessage = webClient.GetAsync(url).Result;
                string json = responseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<TReturnType>(json);
            }
        }

        public void CreateChannel(NewChannelRequest request)
        {
            var url = "API/CHANNEL";
            PostDataToApi<object, NewChannelRequest>(request, url);
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
    }
}


