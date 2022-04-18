﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.DB;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220418050135_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Server.DB.AccountDb", b =>
                {
                    b.Property<int>("AccountDbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountDbId"), 1L, 1);

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccountDbId");

                    b.HasIndex("AccountName")
                        .IsUnique()
                        .HasFilter("[AccountName] IS NOT NULL");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Server.DB.PlayerDb", b =>
                {
                    b.Property<int>("PlayerDbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerDbId"), 1L, 1);

                    b.Property<int?>("AccountDbId")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PlayerDbId");

                    b.HasIndex("AccountDbId");

                    b.HasIndex("PlayerName")
                        .IsUnique()
                        .HasFilter("[PlayerName] IS NOT NULL");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Server.DB.PlayerDb", b =>
                {
                    b.HasOne("Server.DB.AccountDb", "Account")
                        .WithMany("Players")
                        .HasForeignKey("AccountDbId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Server.DB.AccountDb", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
