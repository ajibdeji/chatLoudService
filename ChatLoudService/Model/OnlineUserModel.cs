namespace ChatLoudService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

   
    [DataContract]
    public class OnlineUserModel
    {
        [DataMember]
        public string Id { get; set; }

        
        [DataMember]
        public string ConnId { get; set; }

        [DataMember]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
