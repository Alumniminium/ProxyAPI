﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProxyAPI.Models;

namespace ProxyAPI.Migrations
{
    [DbContext(typeof(ProxyDbContext))]
    partial class ProxyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ProxyAPI.Models.Proxy", b =>
                {
                    b.Property<ulong>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("IP")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastTest")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Proxies");
                });
#pragma warning restore 612, 618
        }
    }
}
