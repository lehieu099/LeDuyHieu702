// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

namespace LeDuyHieu702.Migrations
{
    [DbContext(typeof(LeDuyHieu702Context))]
    [Migration("20211216010354_Create_Table_University")]
    partial class Create_Table_University
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("LeDuyHieu702.Models.UniversityLDH702", b =>
                {
                    b.Property<string>("UniversityId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("UniversityId");

                    b.ToTable("University");
                });
#pragma warning restore 612, 618
        }
    }
}
