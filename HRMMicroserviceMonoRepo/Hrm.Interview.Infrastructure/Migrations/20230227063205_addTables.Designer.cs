﻿// <auto-generated />
using System;
using Hrm.Interview.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hrm.Interview.Infrastructure.Migrations
{
    [DbContext(typeof(InterviewDbContext))]
    [Migration("20230227063205_addTables")]
    partial class addTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hrm.Interview.ApplicationCore.Entity.InterviewFeedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("Raring")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InterviewFeedback");
                });

            modelBuilder.Entity("Hrm.Interview.ApplicationCore.Entity.InterviewType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("InterviewType");
                });

            modelBuilder.Entity("Hrm.Interview.ApplicationCore.Entity.Interviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Interviewer");
                });

            modelBuilder.Entity("Hrm.Interview.ApplicationCore.Entity.Interviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("InterviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InterviewFeedbackId")
                        .HasColumnType("int");

                    b.Property<int>("InterviewRound")
                        .HasColumnType("int");

                    b.Property<int>("InterviewTypeId")
                        .HasColumnType("int");

                    b.Property<int>("InterviewerId")
                        .HasColumnType("int");

                    b.Property<int>("RecruiterId")
                        .HasColumnType("int");

                    b.Property<int>("SubmissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InterviewFeedbackId");

                    b.HasIndex("InterviewTypeId");

                    b.HasIndex("InterviewerId");

                    b.HasIndex("RecruiterId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("Hrm.Interview.ApplicationCore.Entity.Recruiter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Recruiter");
                });

            modelBuilder.Entity("Hrm.Interview.ApplicationCore.Entity.Interviews", b =>
                {
                    b.HasOne("Hrm.Interview.ApplicationCore.Entity.InterviewFeedback", "InterviewFeedback")
                        .WithMany()
                        .HasForeignKey("InterviewFeedbackId");

                    b.HasOne("Hrm.Interview.ApplicationCore.Entity.InterviewType", "InterviewType")
                        .WithMany()
                        .HasForeignKey("InterviewTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hrm.Interview.ApplicationCore.Entity.Interviewer", "Interviewer")
                        .WithMany()
                        .HasForeignKey("InterviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hrm.Interview.ApplicationCore.Entity.Recruiter", "Recruiter")
                        .WithMany()
                        .HasForeignKey("RecruiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InterviewFeedback");

                    b.Navigation("InterviewType");

                    b.Navigation("Interviewer");

                    b.Navigation("Recruiter");
                });
#pragma warning restore 612, 618
        }
    }
}
