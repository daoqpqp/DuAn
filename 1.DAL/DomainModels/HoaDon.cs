using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            //HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        [Key]
        [Column("maHD")]
        public string maHD { get; set; }
        [StringLength(100)]
        public string tenHD { get; set; }
        public DateTime ngayMuaSP { get; set; }
        public DateTime ngaytaoHD { get; set; }
        public DateTime ngayGiaoHang { get; set; }
        public string maNV { get; set; }
        public string maKhachHang { get; set; }

        [ForeignKey("maNV")]
        public virtual NhanVien IDnhanVien { get; set; }

        [ForeignKey("maKhachHang")]
        public virtual KhachHang IDkhachHang { get; set; }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    }
}
