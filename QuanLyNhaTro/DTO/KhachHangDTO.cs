using System;

namespace QuanLyNhaTro.DTO
{
    public class KhachHangDTO
    {
        private string maKH;
        private string tenKH;
        private string gioiTinh;
        private DateTime namSinh;
        private string ngheNghiep;
        private string sDT;
        private string diaChi;
        private string anh;
        private int cMND;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Anh { get => anh; set => anh = value; }
        public int CMND { get => cMND; set => cMND = value; }
    }
}
