using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Election_Graph_And_Statistics_With_SQL_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection=new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ElectionProjectDB;Integrated Security=True");
        private void BtVote_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO  ElectionTable(City,Society_A,Society_B,Society_C,Society_D,Society_E) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",CbxCities.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@p2", TbxSocietyA.Text);
            sqlCommand.Parameters.AddWithValue("@p3", TbxSocietyB.Text);
            sqlCommand.Parameters.AddWithValue("@p4", TbxSocietyC.Text);
            sqlCommand.Parameters.AddWithValue("@p5", TbxSocietyD.Text);
            sqlCommand.Parameters.AddWithValue("@p6", TbxSocietyE.Text);
            if (sqlCommand.Connection.State == ConnectionState.Open)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Cities", sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (sqlCommand.Connection.State == ConnectionState.Open)
            {
                while (dr.Read())
                {
                    CbxCities.DisplayMember=dr[0].ToString();
                    CbxCities.ValueMember=dr[1].ToString();
                    CbxCities.Items.Add(dr[1].ToString());
                }
            }
            else
            {
                MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
