﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnderstandEF.Orm.Context;

#nullable disable

namespace UnderstandEF.Orm.Migrations
{
    [DbContext(typeof(PoetryDbContext))]
    [Migration("20230201153751_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UnderstandEF.Domain.Model.Poem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PoemBody")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("PoemName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("PoetID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PoetID");

                    b.ToTable("Poem", (string)null);
                });

            modelBuilder.Entity("UnderstandEF.Domain.Model.Poet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("POET", (string)null);
                });

            modelBuilder.Entity("UnderstandEF.Domain.Model.Poem", b =>
                {
                    b.HasOne("UnderstandEF.Domain.Model.Poet", "Poet")
                        .WithMany("Poems")
                        .HasForeignKey("PoetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poet");
                });

            modelBuilder.Entity("UnderstandEF.Domain.Model.Poet", b =>
                {
                    b.Navigation("Poems");
                });
#pragma warning restore 612, 618
        }
    }
}
