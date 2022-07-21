using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLKhachHangServices
    {
        //List<ViewHienThi> getViewHangHoa();
        List<KhachHang> getlKhachHangfromDB();
        bool addKhachHang(KhachHang khachhang);
        bool deleteKhachHang(KhachHang khachhang);
        bool updateKhachHang(KhachHang khachhang);

    }
}
