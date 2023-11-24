using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DỰ_ÁN_11.Models
{
    public partial class DU_AN_1Context : DbContext
    {
        public DU_AN_1Context()
        {
        }

        public DU_AN_1Context(DbContextOptions<DU_AN_1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Hoadon> Hoadons { get; set; } = null!;
        public virtual DbSet<Hoadonct> Hoadoncts { get; set; } = null!;
        public virtual DbSet<Khachhang> Khachhangs { get; set; } = null!;
        public virtual DbSet<Khohang> Khohangs { get; set; } = null!;
        public virtual DbSet<Khuyenmai> Khuyenmais { get; set; } = null!;
        public virtual DbSet<Mausac> Mausacs { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Noisanxuat> Noisanxuats { get; set; } = null!;
        public virtual DbSet<Ram> Rams { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Sanphamct> Sanphamcts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DELL\\SQLEXPRESS;Initial Catalog=DU_AN_1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahd);

                entity.ToTable("HOADON");

                entity.Property(e => e.Mahd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAHD");

                entity.Property(e => e.Manv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADON_NHANVIEN");
            });

            modelBuilder.Entity<Hoadonct>(entity =>
            {
                entity.HasKey(e => new { e.Mahd, e.Maspct });

                entity.ToTable("HOADONCT");

                entity.Property(e => e.Mahd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAHD");

                entity.Property(e => e.Maspct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASPCT");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Giamgia)
                    .HasMaxLength(50)
                    .HasColumnName("GIAMGIA");

                entity.Property(e => e.Hinhthucthanhtoan)
                    .HasMaxLength(50)
                    .HasColumnName("HINHTHUCTHANHTOAN");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAKH");

                entity.Property(e => e.Makm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAKM");

                entity.Property(e => e.Ngaymua)
                    .HasColumnType("date")
                    .HasColumnName("NGAYMUA");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tienkhachdua).HasColumnName("TIENKHACHDUA");

                entity.Property(e => e.Tientralai).HasColumnName("TIENTRALAI");

                entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MahdNavigation)
                    .WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Mahd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONCT_HOADON");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONCT_KHACHHANG");

                entity.HasOne(d => d.MakmNavigation)
                    .WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Makm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONCT_KHUYENMAI");

                entity.HasOne(d => d.MaspctNavigation)
                    .WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Maspct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONCT_SANPHAMCT");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makh);

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Makh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAKH");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Idkh)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDKH");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH");
            });

            modelBuilder.Entity<Khohang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KHOHANG");

                entity.Property(e => e.Idsp)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDSP");

                entity.Property(e => e.Masp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KHOHANG");
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => e.Makm)
                    .HasName("PK__KHUYENMA__603F592B2EE2EADC");

                entity.ToTable("KHUYENMAI");

                entity.Property(e => e.Makm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAKM");

                entity.Property(e => e.Loaikm)
                    .HasMaxLength(50)
                    .HasColumnName("LOAIKM");

                entity.Property(e => e.Thongtinkm)
                    .HasMaxLength(50)
                    .HasColumnName("THONGTINKM");
            });

            modelBuilder.Entity<Mausac>(entity =>
            {
                entity.HasKey(e => e.Mamau)
                    .HasName("PK__MAUSAC__7B7346CFF0656B27");

                entity.ToTable("MAUSAC");

                entity.Property(e => e.Mamau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAMAU");

                entity.Property(e => e.Tenmau)
                    .HasMaxLength(50)
                    .HasColumnName("TENMAU");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv);

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Manv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Chucvu)
                    .HasMaxLength(50)
                    .HasColumnName("CHUCVU");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(50)
                    .HasColumnName("GIOITINH");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("HINHANH");

                entity.Property(e => e.Idnv)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNV");

                entity.Property(e => e.Luongcb).HasColumnName("LUONGCB");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.Tennv)
                    .HasMaxLength(50)
                    .HasColumnName("TENNV");

                entity.Property(e => e.Tentk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TENTK");

                entity.Property(e => e.Thamnien)
                    .HasMaxLength(50)
                    .HasColumnName("THAMNIEN");
            });

            modelBuilder.Entity<Noisanxuat>(entity =>
            {
                entity.HasKey(e => e.Mansx)
                    .HasName("PK__NOISANXU__7ABD278D96D4ED62");

                entity.ToTable("NOISANXUAT");

                entity.Property(e => e.Mansx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANSX");

                entity.Property(e => e.Noisanxuat1)
                    .HasMaxLength(50)
                    .HasColumnName("NOISANXUAT");
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.HasKey(e => e.Maram)
                    .HasName("PK__RAM__57A76D7A34CA560D");

                entity.ToTable("RAM");

                entity.Property(e => e.Maram)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MARAM");

                entity.Property(e => e.Loairam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOAIRAM");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp);

                entity.ToTable("SANPHAM");

                entity.Property(e => e.Masp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Camera)
                    .HasMaxLength(50)
                    .HasColumnName("CAMERA");

                entity.Property(e => e.Chatlieu)
                    .HasMaxLength(50)
                    .HasColumnName("CHATLIEU");

                entity.Property(e => e.Chip)
                    .HasMaxLength(50)
                    .HasColumnName("CHIP");

                entity.Property(e => e.Dungluongpin)
                    .HasMaxLength(50)
                    .HasColumnName("DUNGLUONGPIN");

                entity.Property(e => e.Gia).HasColumnName("GIA");

                entity.Property(e => e.Hedieuhanh)
                    .HasMaxLength(50)
                    .HasColumnName("HEDIEUHANH");

                entity.Property(e => e.Hinhsp)
                    .HasMaxLength(50)
                    .HasColumnName("HINHSP");

                entity.Property(e => e.Idsp)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDSP");

                entity.Property(e => e.Kichthuoc).HasColumnName("KICHTHUOC");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(50)
                    .HasColumnName("TENSP");

                entity.Property(e => e.Thuonghieu)
                    .HasMaxLength(50)
                    .HasColumnName("THUONGHIEU");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<Sanphamct>(entity =>
            {
                entity.HasKey(e => e.Maspct)
                    .HasName("PK__SANPHAMC__3D158D86E0A4DC67");

                entity.ToTable("SANPHAMCT");

                entity.Property(e => e.Maspct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASPCT");

                entity.Property(e => e.Gianhap).HasColumnName("GIANHAP");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mamau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAMAU");

                entity.Property(e => e.Mansx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANSX");

                entity.Property(e => e.Maram)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MARAM");

                entity.Property(e => e.Masp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("date")
                    .HasColumnName("NGAYNHAP");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MamauNavigation)
                    .WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Mamau)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCHITIET_MAUSAC");

                entity.HasOne(d => d.MansxNavigation)
                    .WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Mansx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCHITIET_NOISANXUAT");

                entity.HasOne(d => d.MaramNavigation)
                    .WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Maram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCHITIET_RAM");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCHITIET");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
