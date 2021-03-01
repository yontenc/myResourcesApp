﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyResourcesApp.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyResourcesApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MyResourcesApp.Models.Customer", b =>
                {
                    b.Property<string>("CID")
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CID");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("MyResourcesApp.Models.Site", b =>
                {
                    b.Property<int>("SiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Distance")
                        .HasColumnType("numeric");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SiteID");

                    b.ToTable("siteInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
