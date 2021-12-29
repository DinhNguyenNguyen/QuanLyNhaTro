using QuanLyNhaTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    class DichVuDAO
    {
        public static DataTable ShowDichVu()
        {
            DataTable dt = Connection.readData("select * from dichvu");
            return dt;
        }

        public static bool ThemDV(DichVuDTO dv)
        {
           
            string query = string.Format("insert into dichvu values('{0}',N'{1}',N'{2}',{3})", dv.MaDV, dv.TenDV, dv.DVTinh, dv.Gia);
            if (Connection.exeData(query))
            {
                Error.Show("Thêm dịch vụ " + dv.TenDV + " thành công");
                return true;
            }
            else
            {
                Error.Show("Thêm dịch vụ " + dv.TenDV + " thất bại");
                return false;
            }
        }

        public static bool SuaDV(DichVuDTO dv)
        {
            
            string query = string.Format("update dichvu set tendv=N'{0}',dvtinh=N'{1}',gia={2} where madv='{3}')",  dv.TenDV, dv.DVTinh, dv.Gia, dv.MaDV);
            if (Connection.exeData(query))
            {
                Error.Show("Cập nhât dịch vụ "+dv.MaDV+" thành công");
                return true;
            }
            else
            {
                Error.Show("Cập nhật dịch vụ " + dv.MaDV + " thất bại");
                return false;
            }
        }


        public static bool Xoa(DichVuDTO dv)
        {            
            string query = string.Format("delete from dichvu where madv= '{0}'", dv.MaDV);
            if (Connection.exeData(query))
            {
                Error.Show("Xóa dịch vụ " + dv.TenDV + " thành công");
                return true;
            }
            else
            {
                Error.Show("Xóa dịch vụ " + dv.TenDV + " thất bại");
                return false;
            }
        }
    } 
}
