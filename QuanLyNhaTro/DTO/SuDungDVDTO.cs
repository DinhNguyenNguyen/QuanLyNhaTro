using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class SuDungDVDTO
    {
        private string maKH;
        private string maDV;
        private DateTime ngaySD;

        public string MaKH { get => maKH; set => maKH = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public DateTime NgaySD { get => ngaySD; set => ngaySD = value; }
    }
}
