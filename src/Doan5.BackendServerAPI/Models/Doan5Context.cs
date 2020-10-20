using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Doan5Context : DbContext
    {
        public Doan5Context()
        {
        }

        public Doan5Context(DbContextOptions<Doan5Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Binhluan> Binhluan { get; set; }
        public virtual DbSet<Chitietdondathang> Chitietdondathang { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadon { get; set; }
        public virtual DbSet<Dangnhapadmin> Dangnhapadmin { get; set; }
        public virtual DbSet<Danhmucsanpham> Danhmucsanpham { get; set; }
        public virtual DbSet<Dondathang> Dondathang { get; set; }
        public virtual DbSet<Hangsanxuat> Hangsanxuat { get; set; }
        public virtual DbSet<Hoadon> Hoadon { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Khuyenmai> Khuyenmai { get; set; }
        public virtual DbSet<Loaisanpham> Loaisanpham { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcap { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Tintuc> Tintuc { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=Doan5;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Binhluan>(entity =>
            {
                entity.HasKey(e => e.Mabinhluan)
                    .HasName("PK__Binhluan__CB94A9F8F07C1400");

                entity.Property(e => e.Mabinhluan)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Danhgia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masanpham)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Noidungbinhluan).HasMaxLength(100);

                entity.Property(e => e.Thoigian).HasColumnType("date");

                entity.HasOne(d => d.MakhachhangNavigation)
                    .WithMany(p => p.Binhluan)
                    .HasForeignKey(d => d.Makhachhang)
                    .HasConstraintName("FK__Binhluan__Makhac__46E78A0C");

                entity.HasOne(d => d.MasanphamNavigation)
                    .WithMany(p => p.Binhluan)
                    .HasForeignKey(d => d.Masanpham)
                    .HasConstraintName("FK__Binhluan__Masanp__47DBAE45");
            });

            modelBuilder.Entity<Chitietdondathang>(entity =>
            {
                entity.HasKey(e => e.Machitietdondathang)
                    .HasName("PK__Chitietd__953A5193B2EB2AC7");

                entity.Property(e => e.Machitietdondathang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Giamgia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Madondathang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masanpham)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tensanpham).HasMaxLength(50);

                entity.HasOne(d => d.MadondathangNavigation)
                    .WithMany(p => p.Chitietdondathang)
                    .HasForeignKey(d => d.Madondathang)
                    .HasConstraintName("FK__Chitietdo__Madon__534D60F1");

                entity.HasOne(d => d.MasanphamNavigation)
                    .WithMany(p => p.Chitietdondathang)
                    .HasForeignKey(d => d.Masanpham)
                    .HasConstraintName("FK__Chitietdo__Masan__52593CB8");
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => e.Machitiethoadon)
                    .HasName("PK__Chitieth__45BB5FA68B2B06E7");

                entity.Property(e => e.Machitiethoadon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mahoadon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masanpham)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MahoadonNavigation)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.Mahoadon)
                    .HasConstraintName("FK__Chitietho__Mahoa__5DCAEF64");

                entity.HasOne(d => d.MasanphamNavigation)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.Masanpham)
                    .HasConstraintName("FK__Chitietho__Masan__5EBF139D");
            });

            modelBuilder.Entity<Dangnhapadmin>(entity =>
            {
                entity.HasKey(e => e.Maadmin)
                    .HasName("PK__Dangnhap__7715170C0CAB5FC3");

                entity.Property(e => e.Maadmin)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matkhauadmin).HasMaxLength(50);

                entity.Property(e => e.Taikhoanadmin).HasMaxLength(50);

                entity.Property(e => e.Tenadmin).HasMaxLength(50);
            });

            modelBuilder.Entity<Danhmucsanpham>(entity =>
            {
                entity.HasKey(e => e.Madanhmuc)
                    .HasName("PK__Danhmucs__55122CB3AE2F08FF");

                entity.Property(e => e.Madanhmuc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mota).HasMaxLength(20);

                entity.Property(e => e.Tendanhmuc).HasMaxLength(30);
            });

            modelBuilder.Entity<Dondathang>(entity =>
            {
                entity.HasKey(e => e.Madondathang)
                    .HasName("PK__Dondatha__013AB56F3A15AB9A");

                entity.Property(e => e.Madondathang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachinhanhang).HasMaxLength(50);

                entity.Property(e => e.Ghichu).HasMaxLength(50);

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaydat).HasColumnType("date");

                entity.Property(e => e.Tenkhachhang).HasMaxLength(50);

                entity.Property(e => e.Trangthai).HasMaxLength(10);

                entity.HasOne(d => d.MakhachhangNavigation)
                    .WithMany(p => p.Dondathang)
                    .HasForeignKey(d => d.Makhachhang)
                    .HasConstraintName("FK__Dondathan__Makha__4E88ABD4");

                entity.HasOne(d => d.ManhanvienNavigation)
                    .WithMany(p => p.Dondathang)
                    .HasForeignKey(d => d.Manhanvien)
                    .HasConstraintName("FK__Dondathan__Manha__4F7CD00D");
            });

            modelBuilder.Entity<Hangsanxuat>(entity =>
            {
                entity.HasKey(e => e.Mahang)
                    .HasName("PK__Hangsanx__03BBFE213C227F98");

                entity.Property(e => e.Mahang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mota).HasMaxLength(50);

                entity.Property(e => e.Tenhang).HasMaxLength(50);
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahoadon)
                    .HasName("PK__Hoadon__3B2ABEFD304806F3");

                entity.Property(e => e.Mahoadon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Manhacungcap)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaynhap).HasColumnType("date");

                entity.HasOne(d => d.ManhacungcapNavigation)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.Manhacungcap)
                    .HasConstraintName("FK__Hoadon__Manhacun__59FA5E80");

                entity.HasOne(d => d.ManhanvienNavigation)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.Manhanvien)
                    .HasConstraintName("FK__Hoadon__Manhanvi__5AEE82B9");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makhachhang)
                    .HasName("PK__Khachhan__3BE27B7FB99F7786");

                entity.Property(e => e.Makhachhang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.Matkhau).HasMaxLength(50);

                entity.Property(e => e.Taikhoan).HasMaxLength(50);
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => e.Makhuyenmai)
                    .HasName("PK__Khuyenma__BA789CED06B4815E");

                entity.Property(e => e.Makhuyenmai)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Magiamgia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tenkhuyenmai).HasMaxLength(50);

                entity.Property(e => e.Thoigianbatdau).HasMaxLength(20);

                entity.Property(e => e.Thoigianketthuc).HasMaxLength(20);

                entity.Property(e => e.Tinhnangma).HasMaxLength(20);
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.Maloai)
                    .HasName("PK__Loaisanp__3E1DB46D1B2653D6");

                entity.Property(e => e.Maloai)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Madanhmuc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mota).HasMaxLength(50);

                entity.Property(e => e.Tenloai).HasMaxLength(50);

                entity.HasOne(d => d.MadanhmucNavigation)
                    .WithMany(p => p.Loaisanpham)
                    .HasForeignKey(d => d.Madanhmuc)
                    .HasConstraintName("FK__Loaisanph__Madan__38996AB5");
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.HasKey(e => e.Manhacungcap)
                    .HasName("PK__Nhacungc__CFBC425FF000266C");

                entity.Property(e => e.Manhacungcap)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Tennhacungcap).HasMaxLength(50);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manhanvien)
                    .HasName("PK__Nhanvien__4015B8D29FE3E571");

                entity.Property(e => e.Manhanvien)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Chucvu).HasMaxLength(30);

                entity.Property(e => e.Ngaysinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quequan).HasMaxLength(60);

                entity.Property(e => e.Tennhanvien).HasMaxLength(50);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masanpham)
                    .HasName("PK__Sanpham__F24D3A3027282733");

                entity.Property(e => e.Masanpham)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hansudung).HasMaxLength(50);

                entity.Property(e => e.Hinhanh).HasMaxLength(4000);

                entity.Property(e => e.Mahang)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Maloai)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mota).HasMaxLength(4000);

                entity.Property(e => e.Ngaycapnhat).HasColumnType("date");

                entity.Property(e => e.Tensanpham).HasMaxLength(50);

                entity.Property(e => e.Trongluong).HasMaxLength(30);

                entity.Property(e => e.Xuatxu).HasMaxLength(20);

                entity.HasOne(d => d.MahangNavigation)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.Mahang)
                    .HasConstraintName("FK__Sanpham__Mahang__3E52440B");

                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("FK__Sanpham__Maloai__3D5E1FD2");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.HasKey(e => e.Maslider)
                    .HasName("PK__Slider__4A906E809D762F87");

                entity.Property(e => e.Maslider)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hinhanh).HasMaxLength(1000);

                entity.Property(e => e.Mota).HasMaxLength(100);

                entity.Property(e => e.Tenslider).HasMaxLength(50);
            });

            modelBuilder.Entity<Tintuc>(entity =>
            {
                entity.HasKey(e => e.Matintuc)
                    .HasName("PK__Tintuc__7F5381BDECD16D79");

                entity.Property(e => e.Matintuc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anh).HasMaxLength(1000);

                entity.Property(e => e.Mota).HasMaxLength(100);

                entity.Property(e => e.Ngaydang).HasColumnType("date");

                entity.Property(e => e.Nguoidang).HasMaxLength(50);

                entity.Property(e => e.Noidung).HasMaxLength(3000);

                entity.Property(e => e.Tieude).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
