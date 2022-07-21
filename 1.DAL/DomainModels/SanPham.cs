using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            //HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        [Key]
        [Column("maSanPham")]
        public string maSanPham { get; set; }
        [StringLength(100)]
        public string tenSanPham { get; set; }
        public int soLuongSanPhamTon { get; set; }
        public float giaNhap { get; set; }
        public float giaBan { get; set; }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
