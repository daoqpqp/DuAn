using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class _2107 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    maKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKhahHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ngayMuaHang = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.maKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    maNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    soDienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.maNV);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    soLuongSanPhamTon = table.Column<int>(type: "int", nullable: false),
                    giaNhap = table.Column<float>(type: "real", nullable: false),
                    giaBan = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.maSanPham);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenHD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ngayMuaSP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngaytaoHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayGiaoHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maNV = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    maKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.maHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_maKhachHang",
                        column: x => x.maKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "maKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_maNV",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    soLuongDatHang = table.Column<int>(type: "int", nullable: false),
                    giaSanPham = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.maHD, x.maSanPham });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_maHD",
                        column: x => x.maHD,
                        principalTable: "HoaDon",
                        principalColumn: "maHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPham_maSanPham",
                        column: x => x.maSanPham,
                        principalTable: "SanPham",
                        principalColumn: "maSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_maKhachHang",
                table: "HoaDon",
                column: "maKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_maNV",
                table: "HoaDon",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_maSanPham",
                table: "HoaDonChiTiet",
                column: "maSanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
