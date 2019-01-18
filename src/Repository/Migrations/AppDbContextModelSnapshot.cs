﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Repository.DatabaseModels.HeavilyRequestedObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnotherImportantProperty")
                        .HasMaxLength(256);

                    b.Property<string>("SomeProperty")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("HeavilyRequestedObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
