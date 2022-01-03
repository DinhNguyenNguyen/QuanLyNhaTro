using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyNhaTro.DAO;
using QuanLyNhaTro.DTO;

namespace QuanLyNhaTro.GUI
{
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        DichVuDTO dv = new DichVuDTO();
        ThietBiDTO tb = new ThietBiDTO();
        string sqlDV = "select * from dichvu";
        string sqlTB = "select * from thietbi";

        private void loadDV()
        {
            gcDichVu.DataSource = DichVuDAO.ShowDichVu();
            
        }

        private void loadTB()
        {
            gcThietBi.DataSource = ThietBiDAO.ShowTB();
        }
       
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            loadDV();
            loadTB();
            
        }

        private void BatLoiDV()
        {
            if (txtTenDV.EditValue == null || txtTenDV.EditValue.ToString().Equals(""))
            {
                Error.Show("Tên dịch vụ không được bỏ trống");
                txtTenDV.Focus();
                return;
            }
            if (txtDVT.EditValue == null || txtDVT.EditValue.ToString().Equals(""))
            {
                Error.Show("Đơn vị tính không được bỏ trống");
                txtDVT.Focus();
                return;
            }
            if (txtGia.EditValue == null || txtGia.EditValue.ToString().Equals(""))
            {
                Error.Show("Giá không được bỏ trống");
                txtGia.Focus();
                return;
            }
            if (Error.checkName(sqlDV, txtTenDV, "TenDV"))
            {
                XtraMessageBox.Show("Tên dịch vụ '" + txtTenDV.EditValue.ToString() + "' đã tồn tại!\nVui lòng chọn tên khác!", "Thông báo!");
                btnLamMoi.PerformClick();
                return;
            }
        }

        #region Dịch vụ
        private void btnThem_Click(object sender, EventArgs e)
        {            
            BatLoiDV();          
            try
            {
                dv.MaDV = Connection.creatId("DV", sqlDV);
                dv.TenDV = txtTenDV.EditValue.ToString();
                dv.DVTinh = txtDVT.EditValue.ToString();
                dv.Gia = Int32.Parse(txtGia.EditValue.ToString());
                if (Int32.Parse(txtGia.EditValue.ToString()) / 1000 < 1)
                {
                    Error.Show("Giá không được nhỏ hơn 1000");
                    txtGia.Focus();
                    return;
                }
                else  if (DichVuDAO.ThemDV(dv))
                {
                    loadDV();
                    btnLamMoi.PerformClick();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                try
                {
                    dv.MaDV = txtMaDV.EditValue.ToString();

                    if (DichVuDAO.Xoa(dv))
                    {
                        loadDV();
                        btnLamMoi.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Đã hủy lệnh xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            loadDV();

           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dl = XtraMessageBox.Show("Bạn có muốn sửa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                try
                {
                    dv.MaDV = txtMaDV.EditValue.ToString(); ;
                    dv.TenDV = txtTenDV.EditValue.ToString();
                    dv.DVTinh = txtDVT.EditValue.ToString();
                    dv.Gia = Int32.Parse(txtGia.EditValue.ToString());
                    if (Int32.Parse(txtGia.EditValue.ToString()) / 1000 < 1)
                    {
                        Error.Show("Giá không được nhỏ hơn 1000");
                        txtGia.Focus();
                        return;
                    }
                    else if (DichVuDAO.SuaDV(dv))
                    {
                        gcDichVu.DataSource = DichVuDAO.ShowDichVu();
                        btnLamMoi.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Đã hủy lệnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            loadDV();

            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGia.Text = "";
            txtDVT.Text = "";
            txtTenDV.Focus();

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gvDichVu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaDV.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "MaDV").ToString();
            txtTenDV.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "TenDV").ToString();
            txtDVT.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "DVTinh");
            txtGia.Text = gvDichVu.GetRowCellValue(e.RowHandle, "Gia").ToString();
        }
        #endregion


        private void BatLoiTB()
        {
            if (txtTenTB.EditValue == null || txtTenTB.EditValue.ToString().Equals(""))
            {
                Error.Show("Tên thiết bị không được bỏ trống");
                txtTenTB.Focus();
                return;
            }
            if (txtDVTTB.EditValue == null || txtDVTTB.EditValue.ToString().Equals(""))
            {
                Error.Show("Đơn vị tính không được bỏ trống");
                txtDVTTB.Focus();
                return;
            }
            if (txtGiaTB.EditValue == null || txtGiaTB.EditValue.ToString().Equals(""))
            {
                Error.Show("Giá không được bỏ trống");
                txtGiaTB.Focus();
                return;
            }
            if (Error.checkName(sqlTB, txtTenTB, "TenTB"))
            {
                XtraMessageBox.Show("Tên thiết bị '" + txtTenTB.EditValue.ToString() + "' đã tồn tại!\nVui lòng chọn tên khác!", "Thông báo!");
                btnLamMoi.PerformClick();
                return;
            }
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {         
            try
            {
                BatLoiTB();
                tb.MaTB = Connection.creatId("TB", sqlTB);
                tb.TenTB = txtTenTB.EditValue.ToString();
                tb.DVTinh = txtDVTTB.EditValue.ToString();
                tb.Gia = Int32.Parse(txtGiaTB.EditValue.ToString());
                if (tb.Gia / 1000 < 1)
                {
                    Error.Show("Giá không được nhỏ hơn 1000");
                    txtGia.Focus();
                    return;
                }
                else
                {
                    ThietBiDAO.ThemTB(tb);
                    loadTB();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            try
            {
                tb.MaTB = txtMaTB.EditValue.ToString();
                tb.TenTB = txtTenTB.EditValue.ToString();
                tb.DVTinh = txtDVTTB.EditValue.ToString();
                tb.Gia = Int32.Parse(txtGiaTB.EditValue.ToString());
                ThietBiDAO.CapNhatTB(tb);
                loadTB();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            try
            {
                tb.MaTB = txtMaTB.EditValue.ToString();
                ThietBiDAO.XoaTB(tb);
                loadTB();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoiTB_Click(object sender, EventArgs e)
        {
            txtMaTB.Text = "";
            txtTenTB.Text = "";
            txtGiaTB.Text = "";
            txtDVTTB.Text = "";
            txtTenTB.Focus();
        }

        private void gvThietBi_RowClick(object sender, RowClickEventArgs e)
        {
            txtMaTB.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "MaTB").ToString();
            txtTenTB.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "TenTB").ToString();
            txtDVTTB.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "DVTinh");
            txtGiaTB.Text = gvThietBi.GetRowCellValue(e.RowHandle, "Gia").ToString();
        }

        private void txtGiaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Error.KeyPressNumber(sender, e);
        }
    }
}