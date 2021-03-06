﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HousingProvider.Data.Library.Models
{
    public partial class HousingProviderDBContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Complex> Complex { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestType> RequestType { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        public HousingProviderDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Property");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Guid).HasColumnName("Guid ");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Street1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Street2).HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Complex>(entity =>
            {
                entity.ToTable("Complex", "Property");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.ComplexName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Guid).HasColumnName("Guid ");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Url).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Complex)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Property_complex_AddressId");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Complex)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Property_complex_contactid");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact", "Person");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "Person");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_Person_ContactId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_Person_Person_ProviderId");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property", "Property");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Guid).HasColumnName("Guid ");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Property_Property_AddressId");

                entity.HasOne(d => d.Complex)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.ComplexId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Property_Property_ComplexId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Property_Property_ProviderId");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider", "Person");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Guid).HasColumnName("Guid ");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("Request", "Request");

                entity.Property(e => e.Action).HasMaxLength(1000);

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.RepresentativeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequestDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.RequestModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RequestorName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Urgent).HasDefaultValueSql("0");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_request_propertyid");

                entity.HasOne(d => d.RequestType)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.RequestTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_request_requesttypeid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_Request_Statusid");
            });

            modelBuilder.Entity<RequestType>(entity =>
            {
                entity.ToTable("RequestType", "Request");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.RequestTypeDescription)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "Request");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.StatusDescription)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}