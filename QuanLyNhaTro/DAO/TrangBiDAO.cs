using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    class TrangBiDAO
    {
        public static DataTable ShowTB()
        {
            DataTable dt = Connection.readData("select * from trangbi");
            return dt;
        }

        public static bool ThemTB(TrangBiDTO tb)
        {
            string query = string.Format("insert into trangbi values('{0}','{1}')", tb.MaTB,tb.MaPhong);
            if (Connection.exeData(query))
            {
                Error.Show("Thêm trang bị thành công");
                return true;
            }
            else
            {
                Error.Show("Thêm trang bị thất bại");
                return false;
            }
        }

        public static bool CapNhatTB(TrangBiDTO tb)
        {
            string query = string.Format("update trangbi set matb ='{0}', maphong= '{1}', where matb= '{0}') and maphong= '{1}'",tb.MaTB, tb.MaPhong);
            if (Connection.exeData(query))
            {
                Error.Show("Cập nhật trang bị thành công");
                return true;
            }
            else
            {
                Error.Show("Cập nhật trang bị thất bại");
                return false;
            }
        }

        public static bool XoaTB(TrangBiDTO tb)
        {
            string query = string.Format("delete from trangbi where matb='{0}' and maphong='{1}'",tb.MaTB,tb.MaPhong);
            if (Connection.exeData(query))
            {
                Error.Show("Xóa trang bị thành công");
                return true;
            }
            else
            {
                Error.Show("Xóa trang bị thất bại");
                return false;
            }
        }
    }
}
