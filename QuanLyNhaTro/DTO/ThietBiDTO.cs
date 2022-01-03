using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class ThietBiDTO
    {
        private string maTB;
        private string tenTB;
        private string dVTinh;
        private int gia;
        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string DVTinh { get => dVTinh; set => dVTinh = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
