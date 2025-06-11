using Microsoft.EntityFrameworkCore;

namespace ExamWeb_NguyenMinhQuan.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
        {
        }
        public DbSet<Phim> Phims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Phim>().HasData(
                new Phim { Id = 1, Tuade = "Hạ cánh nơi anh", DienVien = "Son Ye Jin, Hyun Bin", TrongNuoc = false, GiaVe = 120000.5, ThoiLuong = 120 },
                new Phim { Id = 2, Tuade = "Mắt biếc", DienVien = "Trần Phương Anh, Đông Nhi", TrongNuoc = true, GiaVe = 100000, ThoiLuong = 105 },
                new Phim { Id = 3, Tuade = "Parasite", DienVien = "Song Kang Ho", TrongNuoc = false, GiaVe = 150000, ThoiLuong = 132 },
                new Phim { Id = 4, Tuade = "Titanic", DienVien = "Leonardo DiCaprio", TrongNuoc = false, GiaVe = 200000, ThoiLuong = 195 },
                new Phim { Id = 5, Tuade = "Bố già", DienVien = "Trấn Thành, Kiều Minh Tuấn", TrongNuoc = true, GiaVe = 90000, ThoiLuong = 130 },
                new Phim { Id = 6, Tuade = "Gái già lắm chiêu", DienVien = "Nhã Phương", TrongNuoc = true, GiaVe = 110000, ThoiLuong = 115 }
            );
        }
    }
}
