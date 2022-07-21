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
    public class QLKhachHangServices: IQLKhachHangServices
    {
        private IKhachHangServices _IQLkhachHang;
        private List<KhachHang> _LstKhachHang;
        public QLKhachHangServices()
        {
            _LstKhachHang = new List<KhachHang>();
            _IQLkhachHang = new KhachHangServices();
            getlKhachHangfromDB();
        }

        public List<KhachHang> getlKhachHangfromDB()
        {
            return _LstKhachHang = _IQLkhachHang.getlKhachHangfromDB();
        }

        public bool addKhachHang(KhachHang khachhang)
        {
            _IQLkhachHang.addKhachHang(khachhang);
            return true;
        }

        public bool deleteKhachHang(KhachHang khachhang)
        {
            _IQLkhachHang.deleteKhachHang(khachhang);
            return true;
        }

        public bool updateKhachHang(KhachHang khachhang)
        {
            _IQLkhachHang.updateKhachHang(khachhang);
            return true;
        }
    }
}
