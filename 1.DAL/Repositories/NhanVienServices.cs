using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienServices : INhanVienServices
    {
        private DatabaseContext _DBcontext;
        private List<NhanVien> _lstnhanviens;
        public NhanVienServices()
        {
            _lstnhanviens = new List<NhanVien>();
            _DBcontext = new DatabaseContext();
            getlNhanVienfromDB();
        }

        public List<NhanVien> getlNhanVienfromDB()
        {
            _lstnhanviens = _DBcontext.NhanViens.ToList();
            return _lstnhanviens;
        }
        public bool addNhanVien(NhanVien nhanvien)
        {
            _DBcontext.NhanViens.Add(nhanvien);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanvien)
        {
            _DBcontext.NhanViens.Remove(nhanvien);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateNhanVien(NhanVien nhanvien)
        {
            _DBcontext.NhanViens.Update(nhanvien);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
