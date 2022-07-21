using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainModels
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        
        public HoaDonChiTiet()
        {

        }
        [Key]
        [Column(Order = 1)]
        public string maHD { get; set; }
        [Key]
        [Column(Order = 2)]
        public string maSanPham { get; set; }
        public int soLuongDatHang { get; set; }
        public int giaSanPham { get; set; }
        [ForeignKey("maHD")]
        public virtual HoaDon IdHD { get; set; }
        [ForeignKey("maSanPham")]
        public virtual SanPham IDSanPham { get; set; }


    }
}
