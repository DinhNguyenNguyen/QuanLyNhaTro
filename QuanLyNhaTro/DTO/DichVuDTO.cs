using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class DichVuDTO
    {
        private string maDV;
        private string tenDV;
        private string dVTinh;
        private int gia;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string DVTinh { get => dVTinh; set => dVTinh = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
