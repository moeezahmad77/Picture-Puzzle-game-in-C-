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
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-2QL8JE1;Initial Catalog=puzzle;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gu = "guest";
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                Random rd = new Random();
                gu += rd.Next(0, 1000);
                string query = "insert into highscore_e(username) values(@username)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username",gu);
                cmd.ExecuteNonQuery();

                query = "insert into highscore_m(username) values(@username)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", gu);
                cmd.ExecuteNonQuery();

            }
            con.Close();
            puzzle_select pz = new puzzle_select(gu);
            pz.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Highscore hg = new Highscore();
            hg.ShowDialog();
        }
    }
}
