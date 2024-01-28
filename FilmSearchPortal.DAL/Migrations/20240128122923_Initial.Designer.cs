﻿// <auto-generated />
using System;
using FilmSearchPortal.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FilmSearchPortal.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240128122923_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.Film", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.FilmActor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ActorId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("FilmId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmActors");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("FilmId")
                        .HasColumnType("uuid");

                    b.Property<int?>("Rate")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.FilmActor", b =>
                {
                    b.HasOne("FilmSearchPortal.DAL.Entities.Actor", "Actor")
                        .WithMany("FilmActors")
                        .HasForeignKey("ActorId");

                    b.HasOne("FilmSearchPortal.DAL.Entities.Film", "Film")
                        .WithMany("FilmActors")
                        .HasForeignKey("FilmId");

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.Review", b =>
                {
                    b.HasOne("FilmSearchPortal.DAL.Entities.Film", "Film")
                        .WithMany("Reviews")
                        .HasForeignKey("FilmId");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.Actor", b =>
                {
                    b.Navigation("FilmActors");
                });

            modelBuilder.Entity("FilmSearchPortal.DAL.Entities.Film", b =>
                {
                    b.Navigation("FilmActors");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
