namespace ChatLoudService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("OnlineUser")]
    [DataContract]
    public partial class OnlineUser
    {
        [DataMember]
        public string Id { get; set; }

        [StringLength(100)]
        [DataMember]
        public string ConnId { get; set; }

        [DataMember]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
