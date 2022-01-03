using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    class ThietBiDAO
    {
        public static DataTable ShowTB()
        {
            DataTable dt = Connection.readData("select * from thietbi");
            return dt;
        }

        public static bool ThemTB(ThietBiDTO tb)
        {
            string query = string.Format("insert into thietbi values('{0}',N'{1}',N'{2}',{3})", tb.MaTB, tb.TenTB, tb.DVTinh, tb.Gia);
            if (Connection.exeData(query))
            {
                Error.Show("Thêm thiết bị thành công");
                return true;
            }
            else
            {
                Error.Show("Thêm thiết bị thất bại");
                return false;
            }
        }

        public static bool CapNhatTB(ThietBiDTO tb)
        {
            string query = string.Format("update thietbi set tebtb=N'{0}, dvtinh= N'{2}', gia= {3} where matb= '{1}')",  tb.TenTB, tb.MaTB, tb.DVTinh,tb.Gia);
            if (Connection.exeData(query))
            {
                Error.Show("Cập nhật thiết bị thành công");
                return true;
            }
            else
            {
                Error.Show("Cập nhật thiết bị thất bại");
                return false;
            }
        }

        public static bool XoaTB(ThietBiDTO tb)
        {
            string query = string.Format("delete from thietbi where matb='{0}'", tb.MaTB);
            if (Connection.exeData(query))
            {
                Error.Show("Xóa thiết bị thành công");
                return true;
            }
            else
            {
                Error.Show("Xóa thiết bị thất bại");
                return false;
            }
        }
    }
}
