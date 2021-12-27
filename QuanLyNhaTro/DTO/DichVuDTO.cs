namespace QuanLyNhaTro.DTO
{
    public class DichVuDTO
    {
        private string maDV;
        private string tenDV;
        private string dVTinh;
        private int giaTien;

        public string MaDV
        {
            get { return maDV; }
            set {  maDV = value; }
        }

        public string TenDV
        {
            get { return tenDV; }
            set {tenDV = value; }
        }

        public string DVTinh
        {
            get {return  dVTinh;}
            set { dVTinh = value; }
        }

        public int GiaTien
        {
            get {return  giaTien; }
            set {  giaTien = value; }
        }


    }
}
