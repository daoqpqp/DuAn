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
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        private DatabaseContext _DBcontext;
        private List<HoaDonChiTiet> _lsthoaDonChiTiets;
        public HoaDonChiTietServices()
        {
            _DBcontext = new DatabaseContext();
            _lsthoaDonChiTiets = new List<HoaDonChiTiet>();
            getlHoaDonChiTietfromDB();
        }

        public List<HoaDonChiTiet> getlHoaDonChiTietfromDB()
        {
            _lsthoaDonChiTiets = _DBcontext.HoaDonChiTiets.ToList();
            return _lsthoaDonChiTiets;
        }
        public bool addHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            _DBcontext.HoaDonChiTiets.Add(hoadonchitiet);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            _DBcontext.HoaDonChiTiets.Remove(hoadonchitiet);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            _DBcontext.HoaDonChiTiets.Update(hoadonchitiet);
            _DBcontext.SaveChanges();
            return true;
        }


    }
}
