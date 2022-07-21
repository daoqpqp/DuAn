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
    public class SanPhamServices : ISanPhamServices
    {
        private DatabaseContext _DBcontext;
        private List<SanPham> _lstsanPhams;
        public SanPhamServices()
        {
            _lstsanPhams = new List<SanPham>();
            _DBcontext = new DatabaseContext();
            getlSanPhamfromDB();
        }

        public List<SanPham> getlSanPhamfromDB()
        {
            _lstsanPhams = _DBcontext.SanPhams.ToList();
            return _lstsanPhams;
        }
        public bool addSanPham(SanPham sanpham)
        {
            _DBcontext.SanPhams.Add(sanpham);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteSanPham(SanPham sanpham)
        {
            _DBcontext.SanPhams.Remove(sanpham);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateSanPham(SanPham sanpham)
        {
            _DBcontext.SanPhams.Update(sanpham);
            _DBcontext.SaveChanges();
            return true;
        }

    }
}
