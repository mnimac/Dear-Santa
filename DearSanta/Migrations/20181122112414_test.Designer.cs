﻿// <auto-generated />
using DearSanta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DearSanta.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181122112414_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DearSanta.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsInStock");

                    b.Property<string>("LongDesc");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("ShortDesc");

                    b.Property<string>("ThumbnailUrl");

                    b.HasKey("Id");

                    b.ToTable("Gifts");
                });
#pragma warning restore 612, 618
        }
    }
}