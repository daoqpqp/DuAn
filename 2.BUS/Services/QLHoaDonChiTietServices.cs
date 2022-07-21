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
    public class QLHoaDonChiTietServices : IQLHoaDonChiTietServices
    {
        private IHoaDonChiTietServices _QLhoadonCT;
        private List<HoaDonChiTiet> _lishoaDonchiTiet;
        public QLHoaDonChiTietServices()
        {
            _QLhoadonCT = new HoaDonChiTietServices();
            _lishoaDonchiTiet = new List<HoaDonChiTiet>();
            getlHoaDonChiTietfromDB();
        }

        public List<HoaDonChiTiet> getlHoaDonChiTietfromDB()
        {
            return _lishoaDonchiTiet = _QLhoadonCT.getlHoaDonChiTietfromDB();
        }

        public bool addHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            _QLhoadonCT.addHoaDonChiTiet(hoadonchitiet);
            return true;
        }

        public bool deleteHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            _QLhoadonCT.deleteHoaDonChiTiet(hoadonchitiet);
            return true;
        }

        public bool updateHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            _QLhoadonCT.updateHoaDonChiTiet(hoadonchitiet);
            return true;
        }
    }
}
