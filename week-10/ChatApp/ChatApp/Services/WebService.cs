using ChatApp.Data;
using ChatApp.Models;
using ChatApp.ViewModels;
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

        public IndexViewModel GetMessages(RequestMessages request)
        {
            string url = "api/channel/get-messages";
            var result = PostDataToApi<IndexViewModel, RequestMessages>(request, url);

            if (request.ChannelId != null)
            {
                string secret = GetChannelSecretFromDb(result.Channel.Id);
                result.Channel.Secret = secret;
            }
            if (ReadKeyFromDb() != null)
            {
                var channels = GetChannels();
                result.Channels = channels.Channels.ToList();
            }
            result.Count = request.Count;
            return result;
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
            if (ReadKeyFromDb() == null)
            {
                return;
            }
            var key = db.KeyHolders.FirstOrDefault();
            db.KeyHolders.Remove(key);
            db.SaveChanges();
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
            var channels = GetDataFromApi<Models.Channel[]>(url)?.ToList();
            foreach (var channel in channels)
            {
                if (!IsInDB(channel))
                {
                    db.Channels.Add(channel);
                    db.SaveChanges();
                }
            }
            channels.Add(InitializeGeneralChannel());
            return new ChannelsViewModel() { Channels = channels };
        }

        private Channel InitializeGeneralChannel()
        {
            return new Channel() { Id = 1, Name = "General", Iconurl = "http://www.mocr.army.cz/assets/struktura/generalni/ngs/armadni-general-ales-opata_4.jpg" };
        }

        public string GetChannelSecretFromDb(int channelID)
        {
            return db.Channels.FirstOrDefault(c => c.Id == channelID)?.Secret;
        }

        private bool IsInDB(Models.Channel channel)
        {
            return db.Channels.Any(c => c.Id == channel.Id);
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


