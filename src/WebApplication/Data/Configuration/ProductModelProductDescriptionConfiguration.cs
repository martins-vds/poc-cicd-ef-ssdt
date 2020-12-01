﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

#nullable disable

namespace WebApplication
{
    public class ProductModelProductDescriptionConfiguration : IEntityTypeConfiguration<ProductModelProductDescription>
    {
        public void Configure(EntityTypeBuilder<ProductModelProductDescription> entity)
        {
            entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.Culture })
                .HasName("PK_ProductModelProductDescription_ProductModelID_ProductDescriptionID_Culture");

            entity.ToTable("ProductModelProductDescription", "SalesLT");

            entity.HasComment("Cross-reference table mapping product descriptions and the language the description is written in.");

            entity.HasIndex(e => e.Rowguid)
                .HasName("AK_ProductModelProductDescription_rowguid")
                .IsUnique();

            entity.Property(e => e.ProductModelId)
                .HasColumnName("ProductModelID")
                .HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");

            entity.Property(e => e.ProductDescriptionId)
                .HasColumnName("ProductDescriptionID")
                .HasComment("Primary key. Foreign key to ProductDescription.ProductDescriptionID.");

            entity.Property(e => e.Culture)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasComment("The culture for which the description is written");

            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .HasComment("Date and time the record was last updated.");

            entity.Property(e => e.Rowguid)
                .HasColumnName("rowguid")
                .HasDefaultValueSql("newid()");

            entity.HasOne(d => d.ProductDescription)
                .WithMany(p => p.ProductModelProductDescriptions)
                .HasForeignKey(d => d.ProductDescriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductModel)
                .WithMany(p => p.ProductModelProductDescriptions)
                .HasForeignKey(d => d.ProductModelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}