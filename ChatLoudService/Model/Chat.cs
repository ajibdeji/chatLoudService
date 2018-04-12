namespace ChatLoudService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Chat
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int clientID { get; set; }

        [DataMember]
        public int channelID { get; set; }

        [DataMember]
        public int recipientID { get; set; }

        [Required]
        public string message { get; set; }

        [DataMember]
        public DateTime timeSent { get; set; }

        [DataMember]
        public virtual Channel Channel { get; set; }

        [DataMember]
        public virtual Chat Chats1 { get; set; }

        [DataMember]
        public virtual Chat Chat1 { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }

        [DataMember]
        public virtual Client Client1 { get; set; }
    }
}
