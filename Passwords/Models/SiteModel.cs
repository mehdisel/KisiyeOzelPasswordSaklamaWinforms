namespace Passwords.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SiteModel : DbContext
    {
        public SiteModel()
            : base("Passwords.Properties.Settings.ConnSites")
        {
        }

        public virtual DbSet<ChangeHistory> ChangeHistories { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<RecordType> RecordTypes { get; set; }
        public virtual DbSet<SiteName> SiteNames { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasMany(e => e.Sites)
                .WithRequired(e => e.Email)
                .HasForeignKey(e => e.IDEmail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Name>()
                .HasMany(e => e.Sites)
                .WithOptional(e => e.Name)
                .HasForeignKey(e => e.IDSiteUserName);

            modelBuilder.Entity<Password>()
                .HasMany(e => e.Sites)
                .WithRequired(e => e.Password)
                .HasForeignKey(e => e.IDPassword)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Password>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Password)
                .HasForeignKey(e => e.IDPassword)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.ChangeHistories)
                .WithRequired(e => e.RecordType)
                .HasForeignKey(e => e.IDType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteName>()
                .HasMany(e => e.Sites)
                .WithRequired(e => e.SiteName)
                .HasForeignKey(e => e.IDSiteName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.ChangeHistories)
                .WithRequired(e => e.Site)
                .HasForeignKey(e => e.IDSites)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Sites)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDAppUser)
                .WillCascadeOnDelete(false);
        }
    }
}
