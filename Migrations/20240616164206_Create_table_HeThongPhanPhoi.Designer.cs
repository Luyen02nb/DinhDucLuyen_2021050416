﻿// <auto-generated />
using ABC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ABC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240616164206_Create_table_HeThongPhanPhoi")]
    partial class Create_table_HeThongPhanPhoi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("ABC.Models.HeThongPhanPhoi", b =>
                {
                    b.Property<string>("MaHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHTPP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaHTPP");

                    b.ToTable("HeThongPhanPhoi");
                });
#pragma warning restore 612, 618
        }
    }
}
