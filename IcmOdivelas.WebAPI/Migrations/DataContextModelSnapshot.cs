﻿// <auto-generated />
using IcmOdivelas.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace IcmOdivelas.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Function", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.MemberFunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FunctionId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberFunctions");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Category", b =>
                {
                    b.HasOne("IcmOdivelas.WebAPI.Models.Member", "members")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("members");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Member", b =>
                {
                    b.HasOne("IcmOdivelas.WebAPI.Models.Group", null)
                        .WithMany("Members")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.MemberFunction", b =>
                {
                    b.HasOne("IcmOdivelas.WebAPI.Models.Function", "function")
                        .WithMany("MemberFunctions")
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IcmOdivelas.WebAPI.Models.Member", "members")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("function");

                    b.Navigation("members");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Function", b =>
                {
                    b.Navigation("MemberFunctions");
                });

            modelBuilder.Entity("IcmOdivelas.WebAPI.Models.Group", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
