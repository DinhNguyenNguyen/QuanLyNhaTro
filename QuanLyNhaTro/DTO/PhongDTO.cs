using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class PhongDTO
    {
        private string maPhong;
        private string tenPhong;
        private int sLNguoiMax;
        private int sLNNow;
        private string trangThai;

        public string MaPhong
        {
            get { return  maPhong; }
            set {  maPhong = value; }
        }
        public string TenPhong
        {
            get { return  tenPhong; }
            set {  tenPhong = value; }
        }
        public int SLNguoiMax
        {
            get { return  sLNguoiMax; }
            set {  sLNguoiMax = value; }
        }
        public int SLNNow
        {
            get { return  sLNNow; }
            set {  sLNNow = value; }
        }
        public string TrangThai
        {
            get { return  trangThai; }
            set {  trangThai = value; }
        }

        public PhongDTO(string maPhong, string tenPhong, int sLNguoiMax, string sLnNow, string trangThai)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.SLNguoiMax = sLNguoiMax;
            this.TrangThai = TrangThai;
        }
    }
}
