using System;
using QuanLyNhaTro.DAO;

namespace QuanLyNhaTro.GUI
{
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        DichvuDAO DV = new DichvuDAO();

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            gcDichVu.DataSource = DichvuDAO.ShowDichVu();
        }
    }
}