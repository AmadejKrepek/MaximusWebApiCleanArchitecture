﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(StationContext))]
    partial class StationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Station", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("Altitude")
                        .HasColumnType("double");

                    b.Property<int>("ConnectionStatus")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DateDeleted")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<float?>("Latitude")
                        .HasColumnType("float");

                    b.Property<float?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("UnitOfMeasurement")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stations");
                });
#pragma warning restore 612, 618
        }
    }
}
