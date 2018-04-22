namespace ChatLoudService.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChatLoud : DbContext
    {
        public ChatLoud()
            : base("name=ChatLoud")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<GChat> GChats { get; set; }
        public virtual DbSet<OnlineUser> OnlineUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Chats)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.recipientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Chats1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.clientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.GChats)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.clientID);

            modelBuilder.Entity<AspNetUser>()
                .HasOptional(e => e.OnlineUser)
                .WithRequired(e => e.AspNetUser);

            modelBuilder.Entity<Channel>()
                .Property(e => e.channelName)
                .IsUnicode(false);

            modelBuilder.Entity<Channel>()
                .Property(e => e.channelDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Chat>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<GChat>()
                .Property(e => e.message)
                .IsUnicode(false);
        }
    }
}
