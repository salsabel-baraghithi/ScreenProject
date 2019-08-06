﻿// <auto-generated />
using System;
using EventsScreenProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventsScreenProject.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20190805081326_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventsScreenProject.Models.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob");

                    b.Property<string>("Email");

                    b.Property<string>("FName");

                    b.Property<DateTime>("HiringDate");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LName");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EventsScreenProject.Models.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<TimeSpan>("EndTime");

                    b.Property<int>("Priority");

                    b.Property<string>("Repeat");

                    b.Property<TimeSpan>("StartTime");

                    b.Property<long>("TemplateId");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventsScreenProject.Models.EventField", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EventId");

                    b.Property<long>("TemplateFiledId");

                    b.Property<string>("Type");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("TemplateFiledId");

                    b.ToTable("EventFields");
                });

            modelBuilder.Entity("EventsScreenProject.Models.Template", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackgroundImg");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("EventsScreenProject.Models.TemplateField", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FontColor");

                    b.Property<string>("FontFamily");

                    b.Property<string>("FontSize");

                    b.Property<string>("FontStyle");

                    b.Property<string>("FontWeight");

                    b.Property<int?>("LeftPosition");

                    b.Property<string>("Name");

                    b.Property<long?>("TemplateId");

                    b.Property<int?>("TopPosition");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("TemplateFields");
                });

            modelBuilder.Entity("EventsScreenProject.Models.Event", b =>
                {
                    b.HasOne("EventsScreenProject.Models.Template", "MyTemplate")
                        .WithMany("Events")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsScreenProject.Models.EventField", b =>
                {
                    b.HasOne("EventsScreenProject.Models.Event", "MyEvent")
                        .WithMany("EventFields")
                        .HasForeignKey("EventId");

                    b.HasOne("EventsScreenProject.Models.TemplateField", "MyTemplateField")
                        .WithMany("EventFields")
                        .HasForeignKey("TemplateFiledId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsScreenProject.Models.TemplateField", b =>
                {
                    b.HasOne("EventsScreenProject.Models.Template", "MyTemplate")
                        .WithMany("TemplateFields")
                        .HasForeignKey("TemplateId");
                });
#pragma warning restore 612, 618
        }
    }
}
