namespace ChatLoudService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("GChat")]
    [DataContract]
    public partial class GChat
    {
        [DataMember]
        public int ID { get; set; }

        [StringLength(128)]
        [DataMember]
        public string clientID { get; set; }

        [DataMember]
        public int? channelID { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public DateTime? timeSent { get; set; }

        [DataMember]
        public virtual AspNetUser AspNetUser { get; set; }

        [DataMember]
        public virtual Channel Channel { get; set; }
    }
}
