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
    public partial class Signup : Form
    {
        SqlConnection con;
        public Signup()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-2QL8JE1;Initial Catalog=puzzle;Integrated Security=True");
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user.Text) ||
                string.IsNullOrEmpty(em.Text) ||
                string.IsNullOrEmpty(passwd.Text) ||
                string.IsNullOrEmpty(cpasswd.Text))
            {
                MessageBox.Show("Fields can not be empty");
            }
            else
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string query;
                    query = "select * from user_info where username=@username";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", user.Text);
                    SqlDataReader data_r = cmd.ExecuteReader();
                    if (data_r.HasRows)
                    {
                        MessageBox.Show("Username already exists");
                        con.Close();
                        return;
                    }
                    data_r.Close();

                    if (!em.Text.Contains("@") ||
                        !em.Text.Contains(".com"))
                    {
                        MessageBox.Show("Invalid email address");
                        con.Close();
                        return;
                    }
                    query = "select * from user_info where email=@email";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@email", em.Text);
                    data_r = cmd.ExecuteReader();
                    if (data_r.HasRows)
                    {
                        MessageBox.Show("Email already exists");
                        con.Close();
                        return;
                    }
                    data_r.Close();
                    if (passwd.Text != cpasswd.Text)
                    {
                        MessageBox.Show("Confirm Password incorrect");
                        con.Close();
                        return;
                    }

                    query = "insert into user_info(username,email,passwd) values(@username,@email,@passwd)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", user.Text);
                    cmd.Parameters.AddWithValue("@email", em.Text);
                    cmd.Parameters.AddWithValue("@passwd", passwd.Text);
                    cmd.ExecuteNonQuery();
                    query = "insert into highscore_e(username) values(@username)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", user.Text);
                    cmd.ExecuteNonQuery();
                    query = "insert into highscore_m(username) values(@username)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", user.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                puzzle_select pz = new puzzle_select(user.Text);
                this.Close();
                pz.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}