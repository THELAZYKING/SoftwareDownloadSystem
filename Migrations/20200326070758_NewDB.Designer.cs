﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftwareDownloadSystem.Models;

namespace SoftwareDownloadSystem.Migrations
{
    [DbContext(typeof(SDS_DBContext))]
    [Migration("20200326070758_NewDB")]
    partial class NewDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoftwareDownloadSystem.Models.SoftwareDownload", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Employee_Code")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Employee_EmailID")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("Employee_Request_Time")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Level_Status")
                        .HasColumnType("bit");

                    b.Property<string>("NSD_Response_Link")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("NSD_Response_Remark")
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("NSD_Response_Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NSD_Response_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Software_License")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Software_Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Software_Version")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Team_Lead_ID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Team_Lead_Reamrk")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Team_Lead_Response_Time")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Team_Lead_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Website_Link")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("softwareDownloadsystem");
                });
#pragma warning restore 612, 618
        }
    }
}
