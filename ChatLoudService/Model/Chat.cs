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

        [Required]
        [StringLength(128)]
        [DataMember]
        public string clientID { get; set; }

        [Required]
        [StringLength(128)]
        [DataMember]
        public string recipientID { get; set; }

        [Required]
        [DataMember]
        public string message { get; set; }

        [DataMember]
        public DateTime timeSent { get; set; }

        [DataMember]
        public virtual AspNetUser AspNetUser { get; set; }

        [DataMember]
        public virtual AspNetUser AspNetUser1 { get; set; }
    }
}
