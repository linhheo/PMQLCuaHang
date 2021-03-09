using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOHOPUB2HAND.Models
{
    [Table("Nhanviens")]
    public class Nhanvien
    {
        [Key]
        public string NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        public string SoTK { get; set; }
    }
}