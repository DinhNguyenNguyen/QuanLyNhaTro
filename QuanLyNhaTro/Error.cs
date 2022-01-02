using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
