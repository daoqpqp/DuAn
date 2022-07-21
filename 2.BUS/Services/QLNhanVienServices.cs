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
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private INhanVienServices _IQLNhanVien;
        private List<NhanVien> _LstNhanVien;
        public QLNhanVienServices()
        {
            _LstNhanVien = new List<NhanVien>();
            _IQLNhanVien = new NhanVienServices();
            getlNhanVienfromDB();
        }

        public List<NhanVien> getlNhanVienfromDB()
        {
            return _LstNhanVien = _IQLNhanVien.getlNhanVienfromDB();
        }

        public bool addNhanVien(NhanVien nhanvien)
        {
            _IQLNhanVien.addNhanVien(nhanvien);
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanvien)
        {
            _IQLNhanVien.deleteNhanVien(nhanvien);
            return true;
        }

        public bool updateNhanVien(NhanVien nhanvien)
        {
            _IQLNhanVien.updateNhanVien(nhanvien);
            return true;
        }
    }
}
