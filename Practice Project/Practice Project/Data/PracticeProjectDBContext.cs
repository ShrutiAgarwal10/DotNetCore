using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Practice_Project.Models;

#nullable disable

namespace Practice_Project.Data
{
    public partial class PracticeProjectDBContext : DbContext
    {
        public PracticeProjectDBContext()
        {
        }

        public PracticeProjectDBContext(DbContextOptions<PracticeProjectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendeesTable> AttendeesTables { get; set; }
        public virtual DbSet<ClientTable> ClientTables { get; set; }
        public virtual DbSet<ConferenceSetupTable> ConferenceSetupTables { get; set; }
        public virtual DbSet<MembersTable> MembersTables { get; set; }
        public virtual DbSet<SessionsTable> SessionsTables { get; set; }
        public virtual DbSet<SponsorsTable> SponsorsTables { get; set; }
        public virtual DbSet<UsersTable> UsersTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS;initial catalog=PracticeProjectDB; trusted_connection=yes;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AttendeesTable>(entity =>
            {
                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.RegistrationType).IsUnicode(false);
            });

            modelBuilder.Entity<ClientTable>(entity =>
            {
                entity.Property(e => e.CustomerName).IsUnicode(false);
            });

            modelBuilder.Entity<ConferenceSetupTable>(entity =>
            {
                entity.Property(e => e.BadgeTemplate).IsUnicode(false);

                entity.Property(e => e.ConferenceName).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.QrcodeFormat).IsUnicode(false);
            });

            modelBuilder.Entity<MembersTable>(entity =>
            {
                entity.Property(e => e.AmsId).ValueGeneratedNever();

                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MemberType).IsUnicode(false);
            });

            modelBuilder.Entity<SessionsTable>(entity =>
            {
                entity.Property(e => e.AmsId).IsUnicode(false);

                entity.Property(e => e.MobileId).IsUnicode(false);

                entity.Property(e => e.SessionName).IsUnicode(false);

                entity.Property(e => e.SpeakerName).IsUnicode(false);
            });

            modelBuilder.Entity<SponsorsTable>(entity =>
            {
                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            modelBuilder.Entity<UsersTable>(entity =>
            {
                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Website).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
