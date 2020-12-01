﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

#nullable disable

namespace WebApplication
{
    public class ProductModelConfiguration : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> entity)
        {
            entity.ToTable("ProductModel", "SalesLT");

            entity.HasIndex(e => e.Name)
                .HasName("AK_ProductModel_Name")
                .IsUnique();

            entity.HasIndex(e => e.Rowguid)
                .HasName("AK_ProductModel_rowguid")
                .IsUnique();

            entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

            entity.Property(e => e.CatalogDescription).HasColumnType("xml");

            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Rowguid)
                .HasColumnName("rowguid")
                .HasDefaultValueSql("newid()");
        }
    }
}
