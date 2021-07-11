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

namespace Puzzle_Game_2._0
{
    public partial class Highscore_individual : Form
    {
        SqlConnection con;
        string nm;
        public Highscore_individual(string name)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-2QL8JE1;Initial Catalog=puzzle;Integrated Security=True");
            nm = name;
        }

        private void Highscore_individual_Load(object sender, EventArgs e)
        {
            con.Open();
            if(con.State==ConnectionState.Open)
            {
                string query;
                query = "select * from highscore_e where username=@username";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@username", nm);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                query = "select * from highscore_m where username=@username";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", nm);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("Can not connect to the database");
            }
        }
    }
}
