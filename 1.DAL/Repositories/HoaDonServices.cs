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
    public class HoaDonServices : IHoaDonServices
    {
        private DatabaseContext _DBcontext;
        private List<HoaDon> _lsthoaDons;
        public HoaDonServices()
        {
            _lsthoaDons = new List<HoaDon>();
            _DBcontext = new DatabaseContext();
            getlHoaDonfromDB();
        }

        public List<HoaDon> getlHoaDonfromDB()
        {
            _lsthoaDons = _DBcontext.HoaDons.ToList();
            return _lsthoaDons;
        }
        public bool addHoaDon(HoaDon hoadon)
        {
            _DBcontext.HoaDons.Add(hoadon);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteHoaDon(HoaDon hoadon)
        {
            _DBcontext.HoaDons.Remove(hoadon);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateHoaDon(HoaDon hoadon)
        {
            _DBcontext.HoaDons.Update(hoadon);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
