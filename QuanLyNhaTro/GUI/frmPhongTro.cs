using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyNhaTro.DAO;
using QuanLyNhaTro.DTO;

namespace QuanLyNhaTro.GUI
{
    public partial class frmPhongTro : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongTro()
        {
            InitializeComponent();
        }

        PhongTroDTO pt = new PhongTroDTO();
        string sqlPT = "select * from phongtro";

        private void loadPhong()
        {
            DataTable dt = PhongTroDAO.ShowPT() ;
           
            dt.Columns.Add("URL", typeof(byte[]));
            gcPhong.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                dr["Anh"] = string.Format(@"~\Image\ImageRoom\{1}", Application.StartupPath, dr["Anh"]);
                Image img = Image.FromFile(dr["Anh"].ToString());
                dr["URL"] = Error.ImageToByteArray(img);
                dt.AcceptChanges();
                dr.SetModified();
            }
        }

        private void BatLoi()
        {
            Error.TextBoxNull(txtTenPhong, "phòng");
            Error.TextBoxNull(txtGia, "giá");
            Error.TextBoxNull(txtAnh, "ảnh");

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BatLoi();
                pt.MaPhong = Connection.creatId("PT", sqlPT);
                pt.TenPhong = txtTenPhong.EditValue.ToString();
                pt.TrangThai = txtTrangThai.EditValue.ToString();
                pt.Gia = Int32.Parse(txtGia.EditValue.ToString());
                pt.Anh = txtAnh.EditValue.ToString();
                if (pt.Gia / 1000 > 1)
                {
                    PhongTroDAO.ThemPT(pt);
                    loadPhong();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Giá không được nhỏ hơn 1000");
                }
            }
            catch(Exception ex)
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
                    BatLoi();
                    pt.MaPhong = txtMaPhong.EditValue.ToString();
                    PhongTroDAO.XoaPT(pt);
                    loadPhong();
                    btnLamMoi.PerformClick();
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
            loadPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dl = XtraMessageBox.Show("Bạn có muốn sửa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                try
                {
                    BatLoi();
                    pt.MaPhong = txtMaPhong.EditValue.ToString(); ;
                    pt.TenPhong = txtTenPhong.EditValue.ToString();
                    pt.TrangThai = txtTrangThai.EditValue.ToString();
                    pt.Gia = Int32.Parse(txtGia.EditValue.ToString());
                    pt.Anh = txtAnh.EditValue.ToString();
                    if (pt.Gia / 1000 > 1)
                    {
                        PhongTroDAO.CapNhatPT(pt);
                        loadPhong();
                        btnLamMoi.PerformClick();
                    }
                    else
                    {
                        XtraMessageBox.Show("Giá không được nhỏ hơn 1000");
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
            loadPhong();
        }    

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtGia.Text = "";
            txtAnh.Text = "";
            txtTenPhong.Focus();
        }

        private void frmPhongTro_Load(object sender, EventArgs e)
        {
            loadPhong();
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaPhong.Text = gvPhong.GetRowCellValue(e.RowHandle, "MaPhong").ToString(); 
            txtGia.Text = gvPhong.GetRowCellValue(e.RowHandle, "Gia").ToString();
            txtAnh.Text = gvPhong.GetRowCellValue(e.RowHandle, "Anh").ToString();
            txtTenPhong.Text = gvPhong.GetRowCellValue(e.RowHandle, "TenPhong").ToString();
            txtTrangThai.Text = gvPhong.GetRowCellValue(e.RowHandle, "TrangThai").ToString();
        }
    }
}