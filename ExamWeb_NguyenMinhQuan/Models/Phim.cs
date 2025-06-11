using System.ComponentModel.DataAnnotations;

namespace ExamWeb_NguyenMinhQuan.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Vui lòng nhập Tựa đề")]
        public string Tuade { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Tên Diễn viên")]
        public string DienVien { get; set; }
        public bool TrongNuoc { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Giá vé!")]
        public double GiaVe { get; set; }
        public int ThoiLuong { get; set; }
    }
}
