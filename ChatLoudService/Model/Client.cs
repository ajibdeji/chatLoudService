namespace ChatLoudService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        public string id { get; set; }

        [StringLength(10)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }
    }
}
