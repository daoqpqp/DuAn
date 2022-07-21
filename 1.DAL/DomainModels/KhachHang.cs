using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            //HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("maKhachHang")]
        public string maKhachHang { get; set; }
        [StringLength(100)]
        public string tenKhahHang { get; set; }
        public bool gioiTinh { get; set; }
        [StringLength(20)]
        public string SDT { get; set; }
        [StringLength(200)]
        public string diaChi { get; set; }
        public DateTime ngayMuaHang { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
