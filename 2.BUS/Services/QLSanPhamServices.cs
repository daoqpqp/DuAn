using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLSanPhamServices : IQLSanPhamServices
    {
        private ISanPhamServices _IQLSanPham;
        private List<SanPham> _LstSanPham;
        public QLSanPhamServices()
        {
            _LstSanPham = new List<SanPham>();
            _IQLSanPham = new SanPhamServices();
            getlSanPhamfromDB();
        }

        public List<SanPham> getlSanPhamfromDB()
        {
            return _LstSanPham = _IQLSanPham.getlSanPhamfromDB();
        }

        public bool addSanPham(SanPham sanpham)
        {
            _IQLSanPham.addSanPham(sanpham);
            return true;
        }

        public bool deleteSanPham(SanPham sanpham)
        {
            _IQLSanPham.deleteSanPham(sanpham);
            return true;
        }

        public bool updateSanPham(SanPham sanpham)
        {
            _IQLSanPham.updateSanPham(sanpham);
            return true;
        }
    }
}
