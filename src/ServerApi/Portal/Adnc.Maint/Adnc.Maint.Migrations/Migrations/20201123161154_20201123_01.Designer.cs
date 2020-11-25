﻿// <auto-generated />
using System;
using Adnc.Infr.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adnc.Maint.Migrations.Migrations
{
    [DbContext(typeof(AdncDbContext))]
    [Migration("20201123161154_20201123_01")]
    partial class _20201123_01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysCfg", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("CfgDesc")
                        .HasColumnName("CfgDesc")
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<string>("CfgName")
                        .HasColumnName("CfgName")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("CfgValue")
                        .HasColumnName("CfgValue")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<long?>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<long?>("ModifyBy")
                        .HasColumnName("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnName("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("SysCfg");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysDict", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<long?>("ModifyBy")
                        .HasColumnName("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnName("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(16) CHARACTER SET utf8mb4")
                        .HasMaxLength(16);

                    b.Property<string>("Num")
                        .HasColumnName("Num")
                        .HasColumnType("varchar(16) CHARACTER SET utf8mb4")
                        .HasMaxLength(16);

                    b.Property<long?>("Pid")
                        .HasColumnName("Pid")
                        .HasColumnType("bigint");

                    b.Property<string>("Tips")
                        .HasColumnName("Tips")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.HasKey("ID");

                    b.ToTable("SysDict");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysLoginLog", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Account")
                        .HasColumnName("Account")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<long?>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Device")
                        .HasColumnName("Device")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Message")
                        .HasColumnName("Message")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteIpAddress")
                        .HasColumnName("RemoteIpAddress")
                        .HasColumnType("varchar(22) CHARACTER SET utf8mb4")
                        .HasMaxLength(22);

                    b.Property<bool>("Succeed")
                        .HasColumnName("Succeed")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasColumnName("UserName")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.HasKey("ID");

                    b.ToTable("SysLoginLog");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysNotice", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnName("Content")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<long?>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnName("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnName("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int?>("Type")
                        .HasColumnName("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SysNotice");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysTask", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<bool?>("Concurrent")
                        .HasColumnName("Concurrent")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cron")
                        .HasColumnName("Cron")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Data")
                        .HasColumnName("Data")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(65535);

                    b.Property<bool?>("Disabled")
                        .HasColumnName("Disabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("ExecAt")
                        .HasColumnName("ExecAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExecResult")
                        .HasColumnName("ExecResult")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(65535);

                    b.Property<string>("JobClass")
                        .HasColumnName("JobClass")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("JobGroup")
                        .HasColumnName("JobGroup")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<long?>("ModifyBy")
                        .HasColumnName("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnName("ModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasColumnName("Note")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("SysTask");
                });

            modelBuilder.Entity("Adnc.Maint.Core.Entities.SysTaskLog", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ExecAt")
                        .HasColumnName("ExecAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("ExecSuccess")
                        .HasColumnName("ExecSuccess")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("IdTask")
                        .HasColumnName("IdTask")
                        .HasColumnType("bigint");

                    b.Property<string>("JobException")
                        .HasColumnName("JobException")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("SysTaskLog");
                });
#pragma warning restore 612, 618
        }
    }
}
