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
                ChartElection.Series["Society"].Points.AddXY("Society A", sqlDataReader[0]);
                ChartElection.Series["Society"].Points.AddXY("Society B", sqlDataReader[1]);
                ChartElection.Series["Society"].Points.AddXY("Society C", sqlDataReader[2]);
                ChartElection.Series["Society"].Points.AddXY("Society D", sqlDataReader[3]);
                ChartElection.Series["Society"].Points.AddXY("Society E", sqlDataReader[4]);
            }




        }
    }
}
