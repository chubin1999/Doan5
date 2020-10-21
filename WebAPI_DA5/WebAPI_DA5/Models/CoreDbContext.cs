using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI_DA5.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-P4Q9E7U\\SQLEXPRESS;Database=Doan5;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Binhluan>(entity =>
            {
                entity.HasKey(e => e.Mabinhluan)
                    .HasName("PK__Binhluan__CB94A9F8F07C1400");

                entity.Property(e => e.Mabinhluan)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Danhgia)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Makhachhang)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masanpham)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Giamgia).IsUnicode(false);

                entity.Property(e => e.Madondathang)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masanpham)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mahoadon)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masanpham)
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
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Danhmucsanpham>(entity =>
            {
                entity.HasKey(e => e.Madanhmuc)
                    .HasName("PK__Danhmucs__55122CB3AE2F08FF");

                entity.Property(e => e.Madanhmuc)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dondathang>(entity =>
            {
                entity.HasKey(e => e.Madondathang)
                    .HasName("PK__Dondatha__013AB56F3A15AB9A");

                entity.Property(e => e.Madondathang)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Makhachhang)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Manhanvien)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahoadon)
                    .HasName("PK__Hoadon__3B2ABEFD304806F3");

                entity.Property(e => e.Mahoadon)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Manhacungcap)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Manhanvien)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => e.Makhuyenmai)
                    .HasName("PK__Khuyenma__BA789CED06B4815E");

                entity.Property(e => e.Makhuyenmai)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Magiamgia)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.Maloai)
                    .HasName("PK__Loaisanp__3E1DB46D1B2653D6");

                entity.Property(e => e.Maloai)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Madanhmuc)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manhanvien)
                    .HasName("PK__Nhanvien__4015B8D29FE3E571");

                entity.Property(e => e.Manhanvien)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaysinh).IsUnicode(false);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masanpham)
                    .HasName("PK__Sanpham__F24D3A3027282733");

                entity.Property(e => e.Masanpham)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mahang)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Maloai)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tintuc>(entity =>
            {
                entity.HasKey(e => e.Matintuc)
                    .HasName("PK__Tintuc__7F5381BDECD16D79");

                entity.Property(e => e.Matintuc)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
