using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonServices
    {
        //List<ViewHienThi> getViewHangHoa();
        List<HoaDon> getlHoaDonfromDB();
        bool addHoaDon(HoaDon hoadon);
        bool deleteHoaDon(HoaDon hoadon);
        bool updateHoaDon(HoaDon hoadon);
    }
}
