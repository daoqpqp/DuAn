using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonChiTietServices
    {
        List<HoaDonChiTiet> getlHoaDonChiTietfromDB();
        //List<ViewHienThi> getViewHangHoa();
        bool addHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
        bool deleteHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
        bool updateHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
    }
}
