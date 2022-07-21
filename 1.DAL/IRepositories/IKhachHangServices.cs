using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangServices
    {
        List<KhachHang> getlKhachHangfromDB();
        bool addKhachHang(KhachHang khachhang);
        bool deleteKhachHang(KhachHang khachhang);
        bool updateKhachHang(KhachHang khachhang);
    }
}
