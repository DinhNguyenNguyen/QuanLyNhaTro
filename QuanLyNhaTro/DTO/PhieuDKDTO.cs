using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class PhieuDKDTO
    {
        private string maPDK;
        private string maKH;
        private DateTime ngayThue;
        private int traTruoc;
        private DateTime ngayTra;
        private string chuThich;
        private string maPhong;

        public string MaPDK { get => maPDK; set => maPDK = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public int TraTruoc { get => traTruoc; set => traTruoc = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public string ChuThich { get => chuThich; set => chuThich = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
    }
}
