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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform_DataProvider
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();

        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
            cnn.ConnectionString = @"Server=LAKHANGDO\MYDATABASE;Database=StudentDB;User Id=sa;Password=190375;";

            //Init Query

                // Dem Sinh Vien
            SqlCommand cmd1 = new SqlCommand("", cnn);
            cmd1.CommandText = "Select COUNT(*) From SINHVIEN";
                // Them Sinh Vien
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText =
            "Insert into Sinhvien values(11,'Le Nam','1/1/1980',1,null,null)";
            cmd2.Connection = cnn;
                // Tham So Hoa Cau Lenh
            SqlCommand cmd3 = new SqlCommand("", cnn);
            cmd3.CommandText = "Insert into Sinhvien values(@MS, @HT, @NS, @GT, @DC, @DT)";
            cmd3.Parameters.Add("@MS", SqlDbType.Int);
            cmd3.Parameters.Add("@HT", SqlDbType.NVarChar);
            cmd3.Parameters.Add("@NS", SqlDbType.DateTime);
            cmd3.Parameters.Add("@GT", SqlDbType.Bit);
            cmd3.Parameters.Add("@DC", SqlDbType.NVarChar);
            cmd3.Parameters.Add("@DT", SqlDbType.Int);

            cmd3.Parameters["@MS"].Value = 999;
            cmd3.Parameters["@HT"].Value = "Nguyen Ha Giang";
            cmd3.Parameters["@NS"].Value = new DateTime(1978, 12, 4);
            cmd3.Parameters["@GT"].Value = 1;
            cmd3.Parameters["@DC"].Value = "Tan Binh";
            cmd3.Parameters["@DT"].Value = 5120791;
                //Data Reader
            SqlCommand cmd4 = new SqlCommand("Select * From Sinhvien", cnn);

            //Execute
            cnn.Open();

            int count = (int)cmd1.ExecuteScalar();
            MessageBox.Show("So luong sinh vien co trong database la: " + count.ToString());

            //cmd2.ExecuteNonQuery();

            //count = (int)cmd3.ExecuteNonQuery();

            reader = cmd4.ExecuteReader();
            while (reader.Read())
                listBox1.Items.Add(reader["Hoten"]);
            reader.Close();

            cnn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
