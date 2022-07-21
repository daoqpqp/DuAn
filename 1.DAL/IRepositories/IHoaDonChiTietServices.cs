using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTietServices
    {
        List<HoaDonChiTiet> getlHoaDonChiTietfromDB();
        bool addHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
        bool deleteHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
        bool updateHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
    }
}
