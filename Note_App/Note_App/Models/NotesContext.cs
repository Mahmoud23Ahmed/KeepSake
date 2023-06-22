using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Note_App.Models
{
    public partial class NotesContext : DbContext
    {
        public NotesContext()
        {
        }

        public NotesContext(DbContextOptions<NotesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= DESKTOP-ED545EM;Database=Notes;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategName).HasMaxLength(50);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("Note");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategId).HasColumnName("categID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Categ)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CategId)
                    .HasConstraintName("FK_Note_Category1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
