﻿// <auto-generated />
using KnowledgeHubPortal.MVCWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KnowledgeHubPortal.MVCWebApplication.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220329101340_add_catagory")]
    partial class add_catagory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KnowledgeHubPortal.MVCWebApplication.Models.Catagory", b =>
                {
                    b.Property<int>("CatagoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatagoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatagoryID");

                    b.ToTable("Catagories");

                    b.HasData(
                        new
                        {
                            CatagoryID = 111,
                            CatagoryName = "Education",
                            Description = "Its good for childerns"
                        },
                        new
                        {
                            CatagoryID = 222,
                            CatagoryName = "Technology",
                            Description = "All the latest technologies of computer science"
                        },
                        new
                        {
                            CatagoryID = 333,
                            CatagoryName = "Entertinment",
                            Description = "Better way of passing time"
                        },
                        new
                        {
                            CatagoryID = 444,
                            CatagoryName = "Social",
                            Description = "Get a social network"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
