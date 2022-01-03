using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    class PhongTroDAO
    {
        public static DataTable ShowPT()
        {
            DataTable dt = Connection.readData("select * from phongtro");
            return dt;
        }

        public static bool ThemPT(PhongTroDTO pt)
        {
            string query = string.Format("insert into phongtro values('{0}',N'{1}',{2},N'{3}','{4}')", pt.MaPhong,pt.TenPhong, pt.Gia, pt.TrangThai, pt.Anh);
            if (Connection.exeData(query))
            {
                Error.Show("Thêm phòng trọ thành công");
                return true;
            }
            else
            {
                Error.Show("Thêm phòng trọ thất bại");
                return false;
            }
        }

        public static bool CapNhatPT(PhongTroDTO pt)
        {
            string query = string.Format("update phongtro set tenphong=N'{0}',trangthai=N'{1}',anh='{2}', gia={3} where maphong= '{4}')", pt.TenPhong, pt.TrangThai, pt.Anh, pt.Gia, pt.MaPhong);
            if (Connection.exeData(query))
            {
                Error.Show("Cập nhật phòng trọ thành công");
                return true;
            }
            else
            {
                Error.Show("Cập nhật phòng trọ thất bại");
                return false;
            }
        }

        public static bool XoaPT(PhongTroDTO pt)
        {
            string query = string.Format("delete from phongtro where maphong='{0}'", pt.MaPhong);
            if (Connection.exeData(query))
            {
                Error.Show("Xóa phòng trọ thành công");
                return true;
            }
            else
            {
                Error.Show("Xóa phòng trọ thất bại");
                return false;
            }

            
        }
    }
}
