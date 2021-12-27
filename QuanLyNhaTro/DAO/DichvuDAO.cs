using QuanLyNhaTro.DTO;
using System.Data;

namespace QuanLyNhaTro.DAO
{
    class DichvuDAO
    {
        public static DataTable ShowDichVu()
        {
            string query = "select * from DichVu";
            DataTable dtDichvu = Connection.readData(query);
            return dtDichvu;
        }

        public static bool ThemDichVu(DichVuDTO dv)
        {
            try
            {
                string query = string.Format("insert into DichVu values( '{0}',N'{1}',N'{2}',{3} )", dv.MaDV, dv.TenDV,dv.DVTinh,dv.GiaTien) ;
                Connection.exeData(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SuaDichVu(DichVuDTO dv)
        {
            try
            {
                string query = string.Format("update DichVu set tendv=N'{0}',dvtinh=N'{1}',gia={2} where madv='{3}')", dv.MaDV, dv.TenDV, dv.DVTinh, dv.GiaTien);
                Connection.exeData(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaDV(DichVuDTO dv)
        {
            try
            {
                string query = string.Format("delete DichVu where madv='{0}'", dv.MaDV);
                Connection.exeData(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
