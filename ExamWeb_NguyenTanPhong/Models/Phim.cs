using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenTanPhong.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string TuaDe { get; set; }
        [StringLength(50)]
        [Required]
        public string DienVien { get; set; }

        public bool TrongNuoc { get; set; }
        public double GiaVe { get; set; }
        public int ThoiLuong { get; set; }
    }
}
