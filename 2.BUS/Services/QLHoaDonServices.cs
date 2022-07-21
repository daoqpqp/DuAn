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
    public class QLHoaDonServices : IQLHoaDonServices
    {
        private IHoaDonServices _IQLHoaDon;
        private List<HoaDon> _LstHoaDon;
        public QLHoaDonServices()
        {
            _LstHoaDon = new List<HoaDon>();
            _IQLHoaDon = new HoaDonServices();
            getlHoaDonfromDB();
        }

        public List<HoaDon> getlHoaDonfromDB()
        {
            return _LstHoaDon = _IQLHoaDon.getlHoaDonfromDB();
        }

        public bool addHoaDon(HoaDon hoadon)
        {
            _IQLHoaDon.addHoaDon(hoadon);
            return true;
        }

        public bool deleteHoaDon(HoaDon hoadon)
        {
            _IQLHoaDon.deleteHoaDon(hoadon);
            return true;
        }

        public bool updateHoaDon(HoaDon hoadon)
        {
            _IQLHoaDon.updateHoaDon(hoadon);
            return true;
        }

    }
}
