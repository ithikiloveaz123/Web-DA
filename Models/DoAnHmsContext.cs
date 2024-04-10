using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Web_DA.Models;

public partial class DoAnHmsContext : DbContext
{
    public DoAnHmsContext()
    {
    }

    public DoAnHmsContext(DbContextOptions<DoAnHmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CtphieuDatPhong> CtphieuDatPhongs { get; set; }

    public virtual DbSet<CtphieuThuePhong> CtphieuThuePhongs { get; set; }

    public virtual DbSet<DanhSachQuyen> DanhSachQuyens { get; set; }

    public virtual DbSet<DichVu> DichVus { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LienHe> LienHes { get; set; }

    public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhomNhanVien> NhomNhanViens { get; set; }

    public virtual DbSet<PhanHoi> PhanHois { get; set; }

    public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }

    public virtual DbSet<PhieuThuePhong> PhieuThuePhongs { get; set; }

    public virtual DbSet<Phong> Phongs { get; set; }

    public virtual DbSet<QuanTri> QuanTris { get; set; }

    public virtual DbSet<Quyen> Quyens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=AKELO\\THING;Initial Catalog=DoAnHMS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CtphieuDatPhong>(entity =>
        {
            entity.HasKey(e => new { e.MaPdp, e.MaP }).HasName("ctpdp_pk");

            entity.ToTable("CTPhieuDatPhong");

            entity.Property(e => e.MaPdp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPDP");
            entity.Property(e => e.MaP)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maP");
            entity.Property(e => e.TienCoc)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("tienCoc");

            entity.HasOne(d => d.MaPNavigation).WithMany(p => p.CtphieuDatPhongs)
                .HasForeignKey(d => d.MaP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ctpdp_p_fk");

            entity.HasOne(d => d.MaPdpNavigation).WithMany(p => p.CtphieuDatPhongs)
                .HasForeignKey(d => d.MaPdp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ctpdp_pdp_fk");
        });

        modelBuilder.Entity<CtphieuThuePhong>(entity =>
        {
            entity.HasKey(e => new { e.MaPtp, e.MaP, e.NgaySd, e.MaDv }).HasName("ctptp_pk");

            entity.ToTable("CTPhieuThuePhong");

            entity.Property(e => e.MaPtp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPTP");
            entity.Property(e => e.MaP)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maP");
            entity.Property(e => e.NgaySd)
                .HasColumnType("datetime")
                .HasColumnName("ngaySD");
            entity.Property(e => e.MaDv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maDV");
            entity.Property(e => e.SoLuong).HasColumnName("soLuong");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.CtphieuThuePhongs)
                .HasForeignKey(d => d.MaDv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ctptp_dv_fk");

            entity.HasOne(d => d.MaPNavigation).WithMany(p => p.CtphieuThuePhongs)
                .HasForeignKey(d => d.MaP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ctptp_p_fk");

            entity.HasOne(d => d.MaPtpNavigation).WithMany(p => p.CtphieuThuePhongs)
                .HasForeignKey(d => d.MaPtp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ctptp_ptp_fk");
        });

        modelBuilder.Entity<DanhSachQuyen>(entity =>
        {
            entity.HasKey(e => new { e.Idnhom, e.Idquyen });

            entity.ToTable("DanhSachQuyen");

            entity.Property(e => e.Idnhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNhom");
            entity.Property(e => e.Idquyen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDQuyen");
            entity.Property(e => e.GhiChu).HasMaxLength(50);

            entity.HasOne(d => d.IdnhomNavigation).WithMany(p => p.DanhSachQuyens)
                .HasForeignKey(d => d.Idnhom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DanhSachQuyen_NhomNhanVien");

            entity.HasOne(d => d.IdquyenNavigation).WithMany(p => p.DanhSachQuyens)
                .HasForeignKey(d => d.Idquyen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DanhSachQuyen_Quyen");
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDv).HasName("dv_pk");

            entity.ToTable("DichVu");

            entity.Property(e => e.MaDv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maDV");
            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("gia");
            entity.Property(e => e.TenDv)
                .HasMaxLength(50)
                .HasColumnName("tenDV");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaPtp).HasName("hd_pk");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaPtp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPTP");
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maHD");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNV");
            entity.Property(e => e.NgayTt)
                .HasColumnType("datetime")
                .HasColumnName("ngayTT");
            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("tongTien");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hd_nv_fk");

            entity.HasOne(d => d.MaPtpNavigation).WithOne(p => p.HoaDon)
                .HasForeignKey<HoaDon>(d => d.MaPtp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hd_ptp_fk");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("kh_pk");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maKH");
            entity.Property(e => e.CmndPassport)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cmnd_passport");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(50)
                .HasColumnName("diaChi");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GioiTinh).HasColumnName("gioiTinh");
            entity.Property(e => e.QuocTich)
                .HasMaxLength(50)
                .HasColumnName("quocTich");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("tenKH");
        });

        modelBuilder.Entity<LienHe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LienHe__3213E83F1FBEE420");

            entity.ToTable("LienHe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.HoTen)
                .HasMaxLength(50)
                .HasColumnName("hoTen");
            entity.Property(e => e.NgayGui).HasColumnName("ngayGui");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.TinhTrang).HasColumnName("tinhTrang");
        });

        modelBuilder.Entity<LoaiPhong>(entity =>
        {
            entity.HasKey(e => e.MaLp).HasName("lp_pk");

            entity.ToTable("LoaiPhong");

            entity.Property(e => e.MaLp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maLP");
            entity.Property(e => e.DonGia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("donGia");
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("hinhAnh");
            entity.Property(e => e.MoTa)
                .HasMaxLength(500)
                .HasColumnName("moTa");
            entity.Property(e => e.SucChua).HasColumnName("sucChua");
            entity.Property(e => e.TenLp)
                .HasMaxLength(50)
                .HasColumnName("tenLP");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("nv_pk");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNV");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(50)
                .HasColumnName("diaChi");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GioiTinh).HasColumnName("gioiTinh");
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("hinhAnh");
            entity.Property(e => e.NgaySinh).HasColumnName("ngaySinh");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("tenNV");
        });

        modelBuilder.Entity<NhomNhanVien>(entity =>
        {
            entity.HasKey(e => e.Idnhom);

            entity.ToTable("NhomNhanVien");

            entity.Property(e => e.Idnhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNhom");
            entity.Property(e => e.TenNhom).HasMaxLength(50);
        });

        modelBuilder.Entity<PhanHoi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PhanHoi__3213E83FD831E5E3");

            entity.ToTable("PhanHoi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.HoTen)
                .HasMaxLength(50)
                .HasColumnName("hoTen");
            entity.Property(e => e.NgayGui).HasColumnName("ngayGui");
            entity.Property(e => e.NoiDung)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("noiDung");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sdt");
        });

        modelBuilder.Entity<PhieuDatPhong>(entity =>
        {
            entity.HasKey(e => e.MaPdp).HasName("pdp_pk");

            entity.ToTable("PhieuDatPhong");

            entity.Property(e => e.MaPdp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPDP");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNV");
            entity.Property(e => e.NgayDen).HasColumnName("ngayDen");
            entity.Property(e => e.NgayDi).HasColumnName("ngayDi");
            entity.Property(e => e.SoNguoi).HasColumnName("soNguoi");
            entity.Property(e => e.TinhTrang).HasColumnName("tinhTrang");
            entity.Property(e => e.TongTienCoc)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("tongTienCoc");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.PhieuDatPhongs)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pdp_kh_fk");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.PhieuDatPhongs)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pdp_nv_fk");
        });

        modelBuilder.Entity<PhieuThuePhong>(entity =>
        {
            entity.HasKey(e => e.MaPtp).HasName("ptp_pk");

            entity.ToTable("PhieuThuePhong");

            entity.Property(e => e.MaPtp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPTP");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNV");
            entity.Property(e => e.MaPdp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maPDP");
            entity.Property(e => e.NgayThue).HasColumnName("ngayThue");
            entity.Property(e => e.NgayTra).HasColumnName("ngayTra");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.PhieuThuePhongs)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ptp_kh_fk");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.PhieuThuePhongs)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ptp_nv_fk");

            entity.HasOne(d => d.MaPdpNavigation).WithMany(p => p.PhieuThuePhongs)
                .HasForeignKey(d => d.MaPdp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ptp_pdp_fk");
        });

        modelBuilder.Entity<Phong>(entity =>
        {
            entity.HasKey(e => e.MaP).HasName("p_pk");

            entity.ToTable("Phong");

            entity.Property(e => e.MaP)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maP");
            entity.Property(e => e.MaLp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maLP");
            entity.Property(e => e.TinhTrang)
                .HasMaxLength(20)
                .HasColumnName("tinhTrang");

            entity.HasOne(d => d.MaLpNavigation).WithMany(p => p.Phongs)
                .HasForeignKey(d => d.MaLp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("p_lp_fk");
        });

        modelBuilder.Entity<QuanTri>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("qt_pk");

            entity.ToTable("QuanTri");

            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Idnhom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("NHANVIEN")
                .HasColumnName("IDNhom");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maNV");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.TinhTrang).HasColumnName("tinhTrang");

            entity.HasOne(d => d.IdnhomNavigation).WithMany(p => p.QuanTris)
                .HasForeignKey(d => d.Idnhom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("qt_nnv_fk");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.QuanTris)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("qt_nv_fk");
        });

        modelBuilder.Entity<Quyen>(entity =>
        {
            entity.HasKey(e => e.Idquyen);

            entity.ToTable("Quyen");

            entity.Property(e => e.Idquyen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDQuyen");
            entity.Property(e => e.TenQuyen).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
