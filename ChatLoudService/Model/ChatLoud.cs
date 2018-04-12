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

        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>()
                .Property(e => e.channelName)
                .IsUnicode(false);

            modelBuilder.Entity<Channel>()
                .Property(e => e.channelDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Channel>()
                .HasMany(e => e.Chats)
                .WithRequired(e => e.Channel)
                .HasForeignKey(e => e.clientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Chat>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Chat>()
                .HasOptional(e => e.Chats1)
                .WithRequired(e => e.Chat1);

            modelBuilder.Entity<Client>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Chats)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.clientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Chats1)
                .WithRequired(e => e.Client1)
                .HasForeignKey(e => e.recipientID)
                .WillCascadeOnDelete(false);
        }
    }
}
