using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class PhieuTTDTO
    {
        private string maPTT;
        private string maPDK;
        private int soThang;
        private DateTime ngayTT;
        private int tongTien;
        private int tienPhaiTra;

        public string MaPTT { get => maPTT; set => maPTT = value; }
        public string MaPDK { get => maPDK; set => maPDK = value; }
        public int SoThang { get => soThang; set => soThang = value; }
        public DateTime NgayTT { get => ngayTT; set => ngayTT = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int TienPhaiTra { get => tienPhaiTra; set => tienPhaiTra = value; }
    }

}
