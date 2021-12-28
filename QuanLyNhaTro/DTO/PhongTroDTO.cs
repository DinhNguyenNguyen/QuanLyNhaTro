using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class PhongTroDTO
    {
        private string maPhong;
        private string tenPhong;
        private string trangThai;
        private string anh;
        private int gia;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Anh { get => anh; set => anh = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
