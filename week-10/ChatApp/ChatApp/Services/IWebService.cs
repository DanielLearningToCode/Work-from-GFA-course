using ChatApp.DTO;
using ChatApp.Models;
using ChatApp.ViewModels;

namespace ChatApp
{
    public interface IWebService
    {
        void CreateChannel(NewChannelRequest request);
        ChannelsViewModel GetChannels();
        string GetChannelSecretFromDb(int channelID);
        IndexViewModel GetMessages(RequestMessages request);
        void Login(LoginRequest login);
        void LogOut();
        void Register(RegisterRequest login);
        void SendMessage(MessageToSend message);
    }
}