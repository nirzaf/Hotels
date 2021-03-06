// <auto-generated />
using Hotels.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotels.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210530132526_seeding-data")]
    partial class seedingdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotels.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sri Lanka",
                            ShortName = "SL"
                        },
                        new
                        {
                            Id = 2,
                            Name = "India",
                            ShortName = "IN"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Canada",
                            ShortName = "CN"
                        });
                });

            modelBuilder.Entity("Hotels.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kandy",
                            CountryId = 1,
                            Name = "Queens Hotel",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Chennai",
                            CountryId = 2,
                            Name = "Taj Hotel",
                            Rating = 3.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "BC Canada",
                            CountryId = 3,
                            Name = "British Columbia",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("Hotels.Data.Hotel", b =>
                {
                    b.HasOne("Hotels.Data.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
