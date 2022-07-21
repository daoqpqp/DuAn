using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamServices
    {
        //List<ViewHienThi> getViewHangHoa();
        List<SanPham> getlSanPhamfromDB();
        bool addSanPham(SanPham sanpham);
        bool deleteSanPham(SanPham sanpham);
        bool updateSanPham(SanPham sanpham);

    }
}
