﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.Property<string>("maHD")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("maHD");

                    b.Property<string>("maKhachHang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayGiaoHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayMuaSP")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngaytaoHD")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenHD")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("maHD");

                    b.HasIndex("maKhachHang");

                    b.HasIndex("maNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.Property<string>("maHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("giaSanPham")
                        .HasColumnType("int");

                    b.Property<int>("soLuongDatHang")
                        .HasColumnType("int");

                    b.HasKey("maHD", "maSanPham");

                    b.HasIndex("maSanPham");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Property<string>("maKhachHang")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("maKhachHang");

                    b.Property<string>("SDT")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("diaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ngayMuaHang")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenKhahHang")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("maKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Property<string>("maNV")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("maNV");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("diaChi")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("hoTen")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("soDienThoai")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("maNV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("maSanPham");

                    b.Property<float>("giaBan")
                        .HasColumnType("real");

                    b.Property<float>("giaNhap")
                        .HasColumnType("real");

                    b.Property<int>("soLuongSanPhamTon")
                        .HasColumnType("int");

                    b.Property<string>("tenSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("maSanPham");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.KhachHang", "IDkhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("maKhachHang");

                    b.HasOne("_1.DAL.DomainModels.NhanVien", "IDnhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("maNV");

                    b.Navigation("IDkhachHang");

                    b.Navigation("IDnhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.HoaDon", "IdHD")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("maHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.SanPham", "IDSanPham")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("maSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdHD");

                    b.Navigation("IDSanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}