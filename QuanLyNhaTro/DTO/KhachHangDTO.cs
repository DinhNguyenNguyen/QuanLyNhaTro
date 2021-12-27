using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class KhachHangDTO
    {
        private string maKH;
        private string tenKH;
        private DateTime namSinh;
        private int cMND;
        private string diaChi;
        private string ngheNghiep;
        private int sDT;
        private string gioiTinh;
        private string anh;
        private string trangThai;

        public string MaKH
        {
            get { return  maKH; }
            set {  maKH = value; }
        }

        public string TenKH
        {
            get { return  tenKH; }
            set {  tenKH = value; }
        }

        public DateTime NamSinh { get => namSinh; set => namSinh = value; }

        public int CMND
        {
            get { return  cMND; }
            set {  cMND = value; }
        }

        public string DiaChi
        {
            get { return  diaChi; }
            set {  diaChi = value; }
        }

        public string NgheNghiep
        {
            get { return  ngheNghiep; }
            set {  ngheNghiep = value; }
        }

        public int SDT
        {
            get { return  sDT; }
            set {  sDT = value; }
        }

        public string GioiTinh
        {
            get { return  gioiTinh; }
            set {  gioiTinh = value; }
        }

        public string Anh
        {
            get { return  anh; }
            set {  anh = value; }
        }

        public string TrangThai
        {
            get { return  trangThai; }
            set {  trangThai = value; }
        }

        

        public KhachHangDTO(string maKH, string tenKH, DateTime namSinh, int cMND, string diaChi, string ngheNghiep, int sDT, string gioiTinh, string anh, string trangThai)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.NamSinh = namSinh;
            this.CMND = cMND;
            this.DiaChi = diaChi;
            this.NgheNghiep = ngheNghiep;
            this.SDT = sDT;
            this.GioiTinh = gioiTinh;
            this.Anh = anh;
            this.TrangThai = trangThai;
        }
    }
}
