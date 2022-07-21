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
    public class KhachHangServices : IKhachHangServices
    {
        private DatabaseContext _DBcontext;
        private List<KhachHang> _lstKhachHangs;
        public KhachHangServices()
        {
            _lstKhachHangs = new List<KhachHang>();
            _DBcontext = new DatabaseContext();
            getlKhachHangfromDB();
        }

        public List<KhachHang> getlKhachHangfromDB()
        {
            _lstKhachHangs = _DBcontext.KhachHangs.ToList();
            return _lstKhachHangs;
        }
        public bool addKhachHang(KhachHang khachhang)
        {
            _DBcontext.KhachHangs.Add(khachhang);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteKhachHang(KhachHang khachhang)
        {
            _DBcontext.KhachHangs.Remove(khachhang);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateKhachHang(KhachHang khachhang)
        {
            _DBcontext.KhachHangs.Update(khachhang);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
