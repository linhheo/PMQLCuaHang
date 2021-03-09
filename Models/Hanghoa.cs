using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOHOPUB2HAND.Models
{
    [Table("Hanghoas")]
    public class Hanghoa
    {
        [Key]
        public string HangHoaID { get; set; }
        public string TenHangHoa { get; set; }
        public int SoLuongTonKho { get; set; }
        public int DonGia { get; set; }

    }
}