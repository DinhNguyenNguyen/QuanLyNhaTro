using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaTro
{
    class Connection
    {
        public static SqlConnection con = new SqlConnection (@"Data Source=.\sqlexpress;Initial Catalog=QuanLyNhaTro;Integrated Security=True");
        public static void openConnect()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void closeConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //ExecuteData: Them sua xoa du lieu
        public static Boolean exeData(string cmd)
        {
            openConnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeConnect();
            return check;
        }

        public int ExSCL(string cmd)
        {
            openConnect();
            int data;
            SqlCommand sc = new SqlCommand(cmd, con);
            data = Int32.Parse(sc.ExecuteScalar().ToString());
            closeConnect();
            return data;
        }

        public string mysqli_ex_data(string str)
        {
            string data;

            con.Open();
            SqlCommand mysql_cmd = new SqlCommand(str, con);
            data = mysql_cmd.ExecuteScalar().ToString();
            con.Close();
            return data;
        }

        public void Ex_vp(string str)
        {
            openConnect();
            try
            {
                SqlCommand sc = new SqlCommand(str, con);
                sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            closeConnect();

        }

        //ReadData: Doc du lieu tu bang ra DataTable
        public static DataTable readData(string cmd)
        {
            openConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            closeConnect();
            return dt;
        }

        //CreatID: tao ID moi theo tien to(preFix)
        public static string creatId(string preFix, string sql)
        {
            string id = "";
            int countRow = -1;
            bool check = false; //Kiem tra ID khong dung thu tu: Flase
            DataTable dt = readData(sql);
            countRow = dt.Rows.Count; //Dem so luong ban ghi co trong bang         
            if (countRow > 0) //Co nhieu hơn 1 ban ghi thi moi kiem tra
            {
                int count = 1; //ID ao chay song song voi ID trong bang
                foreach (DataRow row in dt.Rows) //Duyet cac dong trong bang
                {
                    string idRow = row[0].ToString(); //Lay chuoi chua ID
                    int i = Int32.Parse(idRow.Substring(idRow.Length - 8, 8)); //Cat chuoi lay ID
                    if (i != count) //Sai thu tu
                    {
                        count = i - 1; //Gan ID ao bang ID that -1
                        check = true; //Check sai thu tu
                        break;
                    }
                    else
                    {
                        count++; //Khong sai thu tu
                    }
                }
                if (check) //Gan ID bị thieu cho ID duoc creat
                {
                    countRow = count;
                }
            }
            if (!check) //Neu khong co ID sai thu tu thi tang len 1 như binh thuong
            {
                countRow += 1;
            }
            if (countRow < 10)
            {
                id = preFix + "0000000" + countRow; //U00009
            }
            else if (countRow < 100)
            {
                id = preFix + "000000" + countRow; //U00999
            }
            else if (countRow < 10000)
            {
                id = preFix + "00000" + countRow; //U09999
            }
            else if (countRow < 100000)
            {
                id = preFix + "0000" + countRow; //U09999
            }
            else if (countRow < 1000000)
            {
                id = preFix + "000" + countRow; //U09999
            }
            else if (countRow < 10000000)
            {
                id = preFix + "00" + countRow; //U09999
            }
            else if (countRow < 100000000)
            {
                id = preFix + "0" + countRow; //U09999
            }
            else if (countRow < 1000000000)
            {
                id = preFix + countRow; //U99999
            }
            return id;
        }

    }
}
