﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProxyAPI.Database;

namespace ProxyAPI.Migrations
{
    [DbContext(typeof(ProxyDbContext))]
    [Migration("20210322064640_remove LastSeen")]
    partial class removeLastSeen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ProxyAPI.Models.Proxy", b =>
                {
                    b.Property<ulong>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AS")
                        .HasColumnType("TEXT");

                    b.Property<string>("ASN")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .HasColumnType("TEXT");

                    b.Property<string>("IP")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISP")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastTest")
                        .HasColumnType("TEXT");

                    b.Property<float>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<float>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<ushort>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProxyType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Threat")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Working")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Proxies");
                });

            modelBuilder.Entity("ProxyAPI.Models.UserInfo", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
