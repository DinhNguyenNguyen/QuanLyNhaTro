using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public class Error
    {
        public static void Show(string text)
        {
            XtraMessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool checkName(string query, TextEdit textEdit, string column)
        {
            bool checkName = false;
            
            DataTable dt = new DataTable();
            dt = Connection.readData(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (textEdit.EditValue.ToString().Trim().Equals(dr[column].ToString()))
                    {
                        checkName = true;
                        // return true;
                        break;
                    }
                }
            }
            return checkName;
        }

        public static void KeyPressNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            
            if (e.KeyChar == (char)Keys.Delete)
            {

            }
        }

        public static void KeyPressDel(object sender, KeyPressEventArgs e, Button btn)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                btn.PerformClick();
            }
        }

        public static void TextBoxNull(TextEdit txt, string name)
        {
            if (txt.EditValue == null || txt.ToString().Equals(""))
            {
                Error.Show("Tên "+name+" không được bỏ trống");
                txt.Focus();
                return;
            }
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

    }
}
