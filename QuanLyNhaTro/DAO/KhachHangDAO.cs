using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    class KhachHangDAO
    {
        public static DataTable ShowKH()
        {
            DataTable dt = Connection.readData("select * from KhachHang");
            return dt;
        }

        public static bool ThemKH(KhachHangDTO kh)
        {
            string query = string.Format("insert into khachhang values('{0}',N'{1}','{2}','{3}',N'{4}',N'{5}','{6}',N'{7}','{8}')",  kh.MaKH, kh.TenKH, kh.NamSinh, kh.CMND, kh.GioiTinh, kh.NgheNghiep, kh.SDT, kh.DiaChi, kh.Anh);
            if (Connection.exeData(query))
            {
                Error.Show("Thêm khách hàng thành công");
                return true;
            }
            else
            {
                Error.Show("Thêm khách hàng thất bại");
                return false;
            }
        }

        public static bool CapNhatKH(KhachHangDTO kh)
        {
            string query = string.Format("update khachhang set tenkh=N'{1}',namsin='{2}',cmnd='{3}',gioitinh=N'{4}',nghenghiep=N'{5}',sdt='{6}',diachi=N'{7}',anh='{8}' where makh='{0}'", kh.MaKH, kh.TenKH, kh.NamSinh, kh.CMND, kh.GioiTinh, kh.NgheNghiep, kh.SDT, kh.DiaChi, kh.Anh);
            if (Connection.exeData(query))
            {
                Error.Show("Cập nhật khách hàng thành công");
                return true;
            }
            else
            {
                Error.Show("Cập nhật khách hàng thất bại");
                return false;
            }
        }

        public static bool XoaKH(KhachHangDTO kh)
        {
            string query = string.Format("delete from khachhang where makh='{0}'", kh.MaKH);
            if (Connection.exeData(query))
            {
                Error.Show("Xóa khách hàng thành công");
                return true;
            }
            else
            {
                Error.Show("Xóa khách hàng thất bại");
                return false;
            }
        }
    }
}
