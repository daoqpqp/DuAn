using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            //HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [Column("maNV")]
        public string maNV { get; set; }
        [StringLength(100)]
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        [StringLength(500)]
        public string diaChi { get; set; }
        [StringLength(20)]
        public string soDienThoai { get; set; }
        [StringLength(100)]
        public string Email { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
