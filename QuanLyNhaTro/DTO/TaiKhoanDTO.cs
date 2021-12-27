using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class TaiKhoanDTO
    {
        private string maTK;
        private string tenTK;
        private string matKhau;

        public string MaTK { get => maTK; set => maTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public TaiKhoanDTO(string maTK, string tenTK, string matKhau)
        {
            this.MaTK = maTK;
            this.TenTK = tenTK;
            this.MatKhau = MatKhau;
        }

    }
}
