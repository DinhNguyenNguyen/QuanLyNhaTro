using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.DTO
{
    public class ThietBiDTO
    {
        private string maTB;
        private string tenTB;
        private int giaTien;

        public string MaTB
        {
            get { return  maTB; }
            set { maTB = value; }
        }

        public string TenTB
        {
            get { return  tenTB; }
            set { tenTB = value; }
        }

        public int GiaTien
        {
            get { return  giaTien; }
            set { giaTien = value; }
        }

        public ThietBiDTO(string maTB, string tenTB, int giaTien)
        {
            this.MaTB = maTB;
            this.TenTB = tenTB;
            this.GiaTien = giaTien;
        }
    }
}
