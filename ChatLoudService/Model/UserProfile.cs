using System.Runtime.Serialization;

namespace ChatLoudService
{
    [DataContract]
    public class UserProfile
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
    }
}