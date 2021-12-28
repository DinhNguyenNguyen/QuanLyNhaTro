using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class HoaDonDTO
    {
        private string maHD;
        private string maPTT;
        private DateTime ngayLap;
        private float thueVAT;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaPTT { get => maPTT; set => maPTT = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public float ThueVAT { get => thueVAT; set => thueVAT = value; }
    }
}
