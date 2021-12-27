using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DAO
{
    public class KhachHangDAO
    {
        static DataTable ShowKH()
        {
            string query = "select * from KhachHang";
            DataTable dt = Connection.readData(query);
            return dt;

        }
    }
}
