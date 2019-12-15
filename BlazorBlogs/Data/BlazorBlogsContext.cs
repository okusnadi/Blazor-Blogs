﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using BlazorBlogs.Data.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorBlogs.Data
{
    public partial class BlazorBlogsContext : DbContext
    {
        public BlazorBlogsContext()
        {
        }

        public BlazorBlogsContext(DbContextOptions<BlazorBlogsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.Property(e => e.BlogContent).IsRequired();

                entity.Property(e => e.BlogDate).HasColumnType("datetime");

                entity.Property(e => e.BlogSummary)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BlogTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BlogUserName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}