namespace ChatLoudService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AspNetUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            Chats = new HashSet<Chat>();
            Chats1 = new HashSet<Chat>();
            GChats = new HashSet<GChat>();
            AspNetRoles = new HashSet<AspNetRole>();
        }

        [DataMember]
        public string Id { get; set; }

        [StringLength(256)]
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool EmailConfirmed { get; set; }

        [DataMember]
        public string PasswordHash { get; set; }

        [DataMember]
        public string SecurityStamp { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public bool PhoneNumberConfirmed { get; set; }

        [DataMember]
        public bool TwoFactorEnabled { get; set; }

        [DataMember]
        public DateTime? LockoutEndDateUtc { get; set; }

        [DataMember]
        public bool LockoutEnabled { get; set; }

        [DataMember]
        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(256)]
        [DataMember]
        public string UserName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Chat> Chats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Chat> Chats1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<GChat> GChats { get; set; }

        [DataMember]
        public virtual OnlineUser OnlineUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
