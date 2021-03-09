using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOHOPUB2HAND.Models
{
    [Table("Nhacungcaps")]
    public class Nhacungcap
    {
        [Key]
        public string NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChỉ { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}