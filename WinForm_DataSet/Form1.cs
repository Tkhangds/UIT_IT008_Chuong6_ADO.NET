using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string strConn = @"Server=LAKHANGDO\MYDATABASE;Database=StudentDB;User Id=sa;Password=190375;";
            string strCmd = "Select * From Sinhvien";
            SqlDataAdapter da = new SqlDataAdapter(strCmd, strConn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            
            da.Fill(ds);

            // Cap nhap ngay sinh thanh hien tai
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //    dr["Ngaysinh"] = DateTime.Now;

            // Xoa nhung ban ghi co ngay sinh nho hon 1/1/1980
            DataTable table = ds.Tables[0];
            DataRow[] rows = table.Select("Ngaysinh<'1/1/1980'");
            foreach (DataRow r in rows)
                r.Delete();

            da.Update(ds);

        }
    }
}
