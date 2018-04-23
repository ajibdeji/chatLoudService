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
        [FaultContract(typeof(ServiceFault))]
        IEnumerable<UserProfile> GetUsers();
        [OperationContract]
        IEnumerable<UserProfile> GetSearchedUsers(String userName);
        [OperationContract]
        UserProfile GetUserProfile(String id);
        [OperationContract]
        UserProfile GetUserProfileByUserName(String userName);
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        IEnumerable<OnlineUserModel> GetOnlineUsers();
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void ConnectUser(OnlineUser online);
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void DisconnectUser(string id);



    }
}
