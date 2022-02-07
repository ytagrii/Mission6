﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission6.Models.Quadrant", b =>
                {
                    b.Property<int>("QuadrantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuadrantName")
                        .HasColumnType("TEXT");

                    b.HasKey("QuadrantId");

                    b.ToTable("quadrant");

                    b.HasData(
                        new
                        {
                            QuadrantId = 1,
                            QuadrantName = "Important/Urgent"
                        },
                        new
                        {
                            QuadrantId = 2,
                            QuadrantName = "Important/Not Urgent"
                        },
                        new
                        {
                            QuadrantId = 3,
                            QuadrantName = "Not Important/Urgent"
                        },
                        new
                        {
                            QuadrantId = 4,
                            QuadrantName = "Not Important/Not Urgent"
                        });
                });

            modelBuilder.Entity("Mission6.Models.TheTask", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuadrantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("QuadrantId");

                    b.ToTable("task");
                });

            modelBuilder.Entity("Mission6.Models.TheTask", b =>
                {
                    b.HasOne("Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mission6.Models.Quadrant", "Quadrant")
                        .WithMany()
                        .HasForeignKey("QuadrantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
