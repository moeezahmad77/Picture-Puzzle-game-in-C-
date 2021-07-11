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
    public partial class Login : Form
    {
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-2QL8JE1;Initial Catalog=puzzle;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string un="";
            if (string.IsNullOrEmpty(em.Text) || string.IsNullOrEmpty(passwd.Text))
            {
                MessageBox.Show("Fields are empty");
                return;
            }
            else
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string query;
                    query = "select * from user_info where email=@email and passwd=@passwd";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@email",em.Text);
                    cmd.Parameters.AddWithValue("@passwd",passwd.Text);
                    SqlDataReader datar = cmd.ExecuteReader();
                    if(datar.HasRows)
                    {
                        datar.Close();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        DataColumn col=ds.Tables[0].Columns[0];
                        foreach(DataRow row in ds.Tables[0].Rows)
                        {
                            un = row[col].ToString();
                        }
                        MessageBox.Show("Login successfull");
                        puzzle_select pz = new puzzle_select(un);
                        this.Close();
                        pz.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User does not exists");
                    }
                }
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
