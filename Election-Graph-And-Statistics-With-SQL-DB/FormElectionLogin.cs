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
    public partial class FormElectionLogin : Form
    {
        public FormElectionLogin()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection=new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ElectionProjectDB;Integrated Security=True");
        private void BtVote_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO  ElectionTable(City,Society_A,Society_B,Society_C,Society_D,Society_E) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnection);

            if (sqlCommand.Connection.State == ConnectionState.Open)
            {
                sqlCommand.Parameters.AddWithValue("@p1", CbxCities.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p2", TbxSocietyA.Text);
                sqlCommand.Parameters.AddWithValue("@p3", TbxSocietyB.Text);
                sqlCommand.Parameters.AddWithValue("@p4", TbxSocietyC.Text);
                sqlCommand.Parameters.AddWithValue("@p5", TbxSocietyD.Text);
                sqlCommand.Parameters.AddWithValue("@p6", TbxSocietyE.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //MessageBox.Show();
            }
        }

        public void GetCitiesToCbx(SqlConnection sqlCon, ComboBox Cbx)
        {
            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Cities", sqlCon);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (sqlCommand.Connection.State == ConnectionState.Open)
            {
                Cbx.SelectedText = "";
                while (dr.Read())
                {
                    Cbx.Items.Add(dr[1]);
                }
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlCon.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetCitiesToCbx(sqlConnection,CbxCities);
        }

        private void BtGraphs_Click(object sender, EventArgs e)
        {
            FormGraphs formGraphs = new FormGraphs();
            formGraphs.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
