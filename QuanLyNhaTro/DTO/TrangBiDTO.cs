using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class TrangBiDTO
    {
        private string maTB;
        private string maPhong;

        public string MaTB { get => maTB; set => maTB = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
    }
}
