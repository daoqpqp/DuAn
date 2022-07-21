using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienServices
    {
        //List<ViewHienThi> getViewHangHoa();
        List<NhanVien> getlNhanVienfromDB();
        bool addNhanVien(NhanVien nhanvien);
        bool deleteNhanVien(NhanVien nhanvien);
        bool updateNhanVien(NhanVien nhanvien);

    }
}
