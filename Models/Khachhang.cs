using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOHOPUB2HAND.Models
{
    [Table("Khachhangs")]
    public class Khachhang
    {
        [Key]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}