using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamServices
    {
        List<SanPham> getlSanPhamfromDB();
        bool addSanPham(SanPham sanpham);
        bool deleteSanPham(SanPham sanpham);
        bool updateSanPham(SanPham sanpham);
    }
}
