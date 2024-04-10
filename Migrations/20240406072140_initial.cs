using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DA.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    maDV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tenDV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gia = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("dv_pk", x => x.maDV);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    maKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    cmnd_passport = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    quocTich = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("kh_pk", x => x.maKH);
                });

            migrationBuilder.CreateTable(
                name: "LienHe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ngayGui = table.Column<DateOnly>(type: "date", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LienHe__3213E83F1FBEE420", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    maLP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tenLP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    hinhAnh = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    sucChua = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lp_pk", x => x.maLP);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    maNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tenNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    ngaySinh = table.Column<DateOnly>(type: "date", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    hinhAnh = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("nv_pk", x => x.maNV);
                });

            migrationBuilder.CreateTable(
                name: "NhomNhanVien",
                columns: table => new
                {
                    IDNhom = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TenNhom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomNhanVien", x => x.IDNhom);
                });

            migrationBuilder.CreateTable(
                name: "PhanHoi",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    noiDung = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    ngayGui = table.Column<DateOnly>(type: "date", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PhanHoi__3213E83FD831E5E3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    IDQuyen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TenQuyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.IDQuyen);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    maP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maLP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_pk", x => x.maP);
                    table.ForeignKey(
                        name: "p_lp_fk",
                        column: x => x.maLP,
                        principalTable: "LoaiPhong",
                        principalColumn: "maLP");
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhong",
                columns: table => new
                {
                    maPDP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ngayDen = table.Column<DateOnly>(type: "date", nullable: false),
                    ngayDi = table.Column<DateOnly>(type: "date", nullable: false),
                    tongTienCoc = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    soNguoi = table.Column<int>(type: "int", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    maNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pdp_pk", x => x.maPDP);
                    table.ForeignKey(
                        name: "pdp_kh_fk",
                        column: x => x.maKH,
                        principalTable: "KhachHang",
                        principalColumn: "maKH");
                    table.ForeignKey(
                        name: "pdp_nv_fk",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV");
                });

            migrationBuilder.CreateTable(
                name: "QuanTri",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    maNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IDNhom = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValue: "NHANVIEN")
                },
                constraints: table =>
                {
                    table.PrimaryKey("qt_pk", x => x.username);
                    table.ForeignKey(
                        name: "qt_nnv_fk",
                        column: x => x.IDNhom,
                        principalTable: "NhomNhanVien",
                        principalColumn: "IDNhom");
                    table.ForeignKey(
                        name: "qt_nv_fk",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV");
                });

            migrationBuilder.CreateTable(
                name: "DanhSachQuyen",
                columns: table => new
                {
                    IDNhom = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IDQuyen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachQuyen", x => new { x.IDNhom, x.IDQuyen });
                    table.ForeignKey(
                        name: "FK_DanhSachQuyen_NhomNhanVien",
                        column: x => x.IDNhom,
                        principalTable: "NhomNhanVien",
                        principalColumn: "IDNhom");
                    table.ForeignKey(
                        name: "FK_DanhSachQuyen_Quyen",
                        column: x => x.IDQuyen,
                        principalTable: "Quyen",
                        principalColumn: "IDQuyen");
                });

            migrationBuilder.CreateTable(
                name: "CTPhieuDatPhong",
                columns: table => new
                {
                    maPDP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tienCoc = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ctpdp_pk", x => new { x.maPDP, x.maP });
                    table.ForeignKey(
                        name: "ctpdp_p_fk",
                        column: x => x.maP,
                        principalTable: "Phong",
                        principalColumn: "maP");
                    table.ForeignKey(
                        name: "ctpdp_pdp_fk",
                        column: x => x.maPDP,
                        principalTable: "PhieuDatPhong",
                        principalColumn: "maPDP");
                });

            migrationBuilder.CreateTable(
                name: "PhieuThuePhong",
                columns: table => new
                {
                    maPTP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maPDP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ngayThue = table.Column<DateOnly>(type: "date", nullable: false),
                    ngayTra = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ptp_pk", x => x.maPTP);
                    table.ForeignKey(
                        name: "ptp_kh_fk",
                        column: x => x.maKH,
                        principalTable: "KhachHang",
                        principalColumn: "maKH");
                    table.ForeignKey(
                        name: "ptp_nv_fk",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV");
                    table.ForeignKey(
                        name: "ptp_pdp_fk",
                        column: x => x.maPDP,
                        principalTable: "PhieuDatPhong",
                        principalColumn: "maPDP");
                });

            migrationBuilder.CreateTable(
                name: "CTPhieuThuePhong",
                columns: table => new
                {
                    maPTP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ngaySD = table.Column<DateTime>(type: "datetime", nullable: false),
                    maDV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ctptp_pk", x => new { x.maPTP, x.maP, x.ngaySD, x.maDV });
                    table.ForeignKey(
                        name: "ctptp_dv_fk",
                        column: x => x.maDV,
                        principalTable: "DichVu",
                        principalColumn: "maDV");
                    table.ForeignKey(
                        name: "ctptp_p_fk",
                        column: x => x.maP,
                        principalTable: "Phong",
                        principalColumn: "maP");
                    table.ForeignKey(
                        name: "ctptp_ptp_fk",
                        column: x => x.maPTP,
                        principalTable: "PhieuThuePhong",
                        principalColumn: "maPTP");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    maPTP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    maHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ngayTT = table.Column<DateTime>(type: "datetime", nullable: false),
                    maNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tongTien = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("hd_pk", x => x.maPTP);
                    table.ForeignKey(
                        name: "hd_nv_fk",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV");
                    table.ForeignKey(
                        name: "hd_ptp_fk",
                        column: x => x.maPTP,
                        principalTable: "PhieuThuePhong",
                        principalColumn: "maPTP");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuDatPhong_maP",
                table: "CTPhieuDatPhong",
                column: "maP");

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuThuePhong_maDV",
                table: "CTPhieuThuePhong",
                column: "maDV");

            migrationBuilder.CreateIndex(
                name: "IX_CTPhieuThuePhong_maP",
                table: "CTPhieuThuePhong",
                column: "maP");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachQuyen_IDQuyen",
                table: "DanhSachQuyen",
                column: "IDQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_maNV",
                table: "HoaDon",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_maKH",
                table: "PhieuDatPhong",
                column: "maKH");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_maNV",
                table: "PhieuDatPhong",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThuePhong_maKH",
                table: "PhieuThuePhong",
                column: "maKH");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThuePhong_maNV",
                table: "PhieuThuePhong",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThuePhong_maPDP",
                table: "PhieuThuePhong",
                column: "maPDP");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_maLP",
                table: "Phong",
                column: "maLP");

            migrationBuilder.CreateIndex(
                name: "IX_QuanTri_IDNhom",
                table: "QuanTri",
                column: "IDNhom");

            migrationBuilder.CreateIndex(
                name: "IX_QuanTri_maNV",
                table: "QuanTri",
                column: "maNV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTPhieuDatPhong");

            migrationBuilder.DropTable(
                name: "CTPhieuThuePhong");

            migrationBuilder.DropTable(
                name: "DanhSachQuyen");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "LienHe");

            migrationBuilder.DropTable(
                name: "PhanHoi");

            migrationBuilder.DropTable(
                name: "QuanTri");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "PhieuThuePhong");

            migrationBuilder.DropTable(
                name: "NhomNhanVien");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "PhieuDatPhong");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
