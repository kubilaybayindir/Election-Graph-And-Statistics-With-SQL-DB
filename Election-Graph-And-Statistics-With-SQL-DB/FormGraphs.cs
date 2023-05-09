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
using System.Windows.Forms.DataVisualization.Charting;

namespace Election_Graph_And_Statistics_With_SQL_DB
{
    public partial class FormGraphs : Form
    {
        public FormGraphs()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ElectionProjectDB;Integrated Security=True");
        private void FormGraphs_Load(object sender, EventArgs e)
        {
            FormElectionLogin formElectionLogin = new FormElectionLogin();
            formElectionLogin.GetCitiesToCbx(sqlConnection,CbxCity);

           


            //To Show Getting Total Elections In Graph
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT SUM(Society_A),SUM(Society_B),SUM(Society_C),SUM(Society_D),SUM(Society_E) FROM ElectionTable", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                //Parameters
                ChartElection.Series["Society"].Points.AddXY("Society A", sqlDataReader[0]);
                ChartElection.Series["Society"].Points.AddXY("Society B", sqlDataReader[1]);
                ChartElection.Series["Society"].Points.AddXY("Society C", sqlDataReader[2]);
                ChartElection.Series["Society"].Points.AddXY("Society D", sqlDataReader[3]);
                ChartElection.Series["Society"].Points.AddXY("Society E", sqlDataReader[4]);

                //Colors
                ChartElection.Series["Society"].Points[0].Color = Color.Green;
                ChartElection.Series["Society"].Points[1].Color = Color.Red;
                ChartElection.Series["Society"].Points[2].Color = Color.PowderBlue;
                ChartElection.Series["Society"].Points[3].Color = Color.Peru;
                ChartElection.Series["Society"].Points[4].Color = Color.Pink;
            }
            sqlConnection.Close();
        }

        private void CbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            ClearAllPage();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ElectionTable WHERE City=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",CbxCity.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                //Fill Value To Progress Bar
                PbSocietyA.Value = int.Parse(sqlDataReader[2].ToString());
                PbSocietyB.Value = int.Parse(sqlDataReader[3].ToString());
                PbSocietyC.Value = int.Parse(sqlDataReader[4].ToString());
                PbSocietyD.Value = int.Parse(sqlDataReader[5].ToString());
                PbSocietyE.Value = int.Parse(sqlDataReader[6].ToString());

                //Fill value of Elections
                LblSocietyA.Text = sqlDataReader[2].ToString();
                LblSocietyB.Text = sqlDataReader[3].ToString();
                LblSocietyC.Text = sqlDataReader[4].ToString();
                LblSocietyD.Text = sqlDataReader[5].ToString();
                LblSocietyE.Text = sqlDataReader[6].ToString();
            }
            sqlConnection.Close();
        }

        public void ClearAllPage()
        {
            LblSocietyA.Text = "0";
            LblSocietyB.Text = "0";
            LblSocietyC.Text = "0";
            LblSocietyD.Text = "0";
            LblSocietyE.Text = "0";

            PbSocietyA.Value = 0;
            PbSocietyB.Value = 0;
            PbSocietyC.Value = 0;
            PbSocietyD.Value = 0;
            PbSocietyE.Value = 0;

        }

    }
}
