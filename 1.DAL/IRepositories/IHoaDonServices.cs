using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonServices
    {
        List<HoaDon> getlHoaDonfromDB();
        bool addHoaDon(HoaDon hoadon);
        bool deleteHoaDon(HoaDon hoadon);
        bool updateHoaDon(HoaDon hoadon);
    }
}
