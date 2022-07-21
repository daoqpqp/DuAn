using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHienThi
    {
        public HoaDon hoadons { get; set; }
        public HoaDonChiTiet HoaDonChiTiets { get; set; }
        public KhachHang khachHangs { get; set; }
        public NhanVien NhanViens { get; set; }
        public SanPham SanPhams { get; set; }
    }
}
