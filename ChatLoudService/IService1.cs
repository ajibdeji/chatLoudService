using ChatLoudService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatLoudService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Channel> GetChannels();
        [OperationContract]
        IEnumerable<AspNetUser> GetUsers();
        [OperationContract]
        IEnumerable<UserProfile> GetSearchedUsers(String userName);
        [OperationContract]
        UserProfile GetUserProfile(String id);
        [OperationContract]
        UserProfile GetUserProfileByUserName(String userName);
        [OperationContract]
        IEnumerable<OnlineUserModel> GetOnlineUsers();
        [OperationContract]
        void ConnectUser(OnlineUser online);
        [OperationContract]
        void DisconnectUser(string id);



    }
}
