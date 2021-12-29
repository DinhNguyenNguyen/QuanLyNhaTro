using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    class SuDungDVADAO
    {
        public static DataTable ShowTB()
        {
            DataTable dt = Connection.readData("select * from sudungDV");
            return dt;
        }

        public static bool ThemTB(SuDungDVDTO sd)
        {
            string query = string.Format("insert into sudungdv values('{0}','{1}', '{2}')", sd.MaKH, sd.MaDV, sd.NgaySD);
            if (Connection.exeData(query))
            {
                Error.Show("Thêm thành công");
                return true;
            }
            else
            {
                Error.Show("Thêm thất bại");
                return false;
            }
        }

        public static bool CapNhatTB(SuDungDVDTO sd)
        {
            string query = string.Format("update sudungdv set makh='{0}', madv='{1}', ngaysd= '{2}' where makh= '{0}' and madv='{1}')", sd.MaKH, sd.MaDV, sd.NgaySD);
            if (Connection.exeData(query))
            {
                Error.Show("Cập nhật thành công");
                return true;
            }
            else
            {
                Error.Show("Cập nhật thất bại");
                return false;
            }
        }

        public static bool XoaTB(SuDungDVDTO sd)
        {
            string query = string.Format("delete from sudungDV where makh='{0}' and ma dv= '{1}'", sd.MaKH, sd.MaDV);
            if (Connection.exeData(query))
            {
                Error.Show("Xóa thành công");
                return true;
            }
            else
            {
                Error.Show("Xóa thất bại");
                return false;
            }
        }
    }
}
