﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MovieId"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descriptions");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ratings");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtime_in_mins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("titles");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4479),
                            Description = "A computer hacker learns about the true nature of his reality",
                            Rating = "R",
                            RuntimeMins = 136,
                            Title = "The Matrix",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4479)
                        },
                        new
                        {
                            MovieId = 2,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4547),
                            Description = "A thief who enters the dreams of others to steal their secrets",
                            Rating = "PG-13",
                            RuntimeMins = 148,
                            Title = "Inception",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4547)
                        },
                        new
                        {
                            MovieId = 3,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4549),
                            Description = "Two imprisoned men bond over a number of years",
                            Rating = "R",
                            RuntimeMins = 142,
                            Title = "The Shawshank Redemption",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4549)
                        },
                        new
                        {
                            MovieId = 4,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4550),
                            Description = "Various interconnected stories of criminals in Los Angeles",
                            Rating = "R",
                            RuntimeMins = 154,
                            Title = "Pulp Fiction",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4551)
                        },
                        new
                        {
                            MovieId = 5,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4552),
                            Description = "The aging patriarch of an organized crime dynasty transfers control to his son",
                            Rating = "R",
                            RuntimeMins = 175,
                            Title = "The Godfather",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4553)
                        },
                        new
                        {
                            MovieId = 6,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4555),
                            Description = "A man with a low IQ witnesses and unwittingly influences several defining historical events",
                            Rating = "PG-13",
                            RuntimeMins = 142,
                            Title = "Forrest Gump",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4555)
                        },
                        new
                        {
                            MovieId = 7,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4557),
                            Description = "A masked vigilante battles the criminal underworld in Gotham City",
                            Rating = "PG-13",
                            RuntimeMins = 152,
                            Title = "The Dark Knight",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4557)
                        },
                        new
                        {
                            MovieId = 8,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4559),
                            Description = "An insomniac office worker and a soapmaker form an underground fight club",
                            Rating = "R",
                            RuntimeMins = 139,
                            Title = "Fight Club",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4559)
                        },
                        new
                        {
                            MovieId = 9,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4560),
                            Description = "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer",
                            Rating = "R",
                            RuntimeMins = 118,
                            Title = "The Silence of the Lambs",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4561)
                        },
                        new
                        {
                            MovieId = 10,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4562),
                            Description = "In Nazi-occupied France, a group of Jewish-American soldiers plan to assassinate Hitler",
                            Rating = "R",
                            RuntimeMins = 153,
                            Title = "Inglourious Basterds",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4563)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("ScreeningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScreeningId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacities");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_numbers");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("movieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.HasKey("ScreeningId");

                    b.HasIndex("movieId");

                    b.ToTable("screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TicketId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("integer")
                        .HasColumnName("num_seats");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("screeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<int>("userId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("TicketId");

                    b.HasIndex("screeningId");

                    b.HasIndex("userId");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emails");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("names");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phonenumbers");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4254),
                            Email = "john.doe@example.com",
                            Name = "John Doe",
                            Phone = "+1234567890",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4258)
                        },
                        new
                        {
                            UserId = 2,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4261),
                            Email = "jane.smith@example.com",
                            Name = "Jane Smith",
                            Phone = "+9876543210",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4262)
                        },
                        new
                        {
                            UserId = 3,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4263),
                            Email = "alice.johnson@example.com",
                            Name = "Alice Johnson",
                            Phone = "+1122334455",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4266)
                        },
                        new
                        {
                            UserId = 4,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4267),
                            Email = "bob.anderson@example.com",
                            Name = "Bob Anderson",
                            Phone = "+9988776655",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4268)
                        },
                        new
                        {
                            UserId = 5,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4270),
                            Email = "eva.white@example.com",
                            Name = "Eva White",
                            Phone = "+6677889900",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4270)
                        },
                        new
                        {
                            UserId = 6,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4271),
                            Email = "david.brown@example.com",
                            Name = "David Brown",
                            Phone = "+1122337788",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4272)
                        },
                        new
                        {
                            UserId = 7,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4274),
                            Email = "sophia.miller@example.com",
                            Name = "Sophia Miller",
                            Phone = "+9988771122",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4274)
                        },
                        new
                        {
                            UserId = 8,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4278),
                            Email = "michael.wilson@example.com",
                            Name = "Michael Wilson",
                            Phone = "+4455667788",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4278)
                        },
                        new
                        {
                            UserId = 9,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4280),
                            Email = "olivia.davis@example.com",
                            Name = "Olivia Davis",
                            Phone = "+1122334466",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4280)
                        },
                        new
                        {
                            UserId = 10,
                            Created_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4283),
                            Email = "daniel.taylor@example.com",
                            Name = "Daniel Taylor",
                            Phone = "+9988775544",
                            Updated_at = new DateTime(2024, 2, 5, 10, 36, 45, 589, DateTimeKind.Utc).AddTicks(4283)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("movieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany("Tickets")
                        .HasForeignKey("screeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screening");

                    b.Navigation("User");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
