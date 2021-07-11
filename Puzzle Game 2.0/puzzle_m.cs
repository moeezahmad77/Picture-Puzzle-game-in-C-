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
    public partial class puzzle_m : Form
    {

        int null_img_index, m = 0, indx;
        List<Bitmap> original_image_list = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        string pzl_n;
        SqlConnection con;
        public puzzle_m(string q, string un)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-2QL8JE1;Initial Catalog=puzzle;Integrated Security=True");
            user.Text = un;
            groupBox1.Text = q;
            pzl_n = q;
            if (q == "puzzle1")
            {
                original_img.Image = Properties.Resources.puzzle1;
                original_image_list.AddRange(new Bitmap[]
                {Properties.Resources.lvl1_m_image_1,Properties.Resources.lvl1_m_image_2,
            Properties.Resources.lvl1_m_image_3,Properties.Resources.lvl1_m_image_4,
            Properties.Resources.lvl1_m_image_5,Properties.Resources.lvl1_m_image_6,
            Properties.Resources.lvl1_m_image_7,Properties.Resources.lvl1_m_image_8,
            Properties.Resources.lvl1_m_image_9,Properties.Resources.lvl1_m_image_10,
            Properties.Resources.lvl1_m_image_11,Properties.Resources.lvl1_m_image_12,
            Properties.Resources.lvl1_m_image_13,Properties.Resources.lvl1_m_image_14,
            Properties.Resources.lvl1_m_image_15,Properties.Resources._null,
            Properties.Resources.lvl1_m_image_16});
                indx = 1;
            }
            else if (q == "puzzle2")
            {
                original_img.Image = Properties.Resources.puzzle2;
                original_image_list.AddRange(new Bitmap[]
                {Properties.Resources.lvl2_m_image_1,Properties.Resources.lvl2_m_image_2,
            Properties.Resources.lvl2_m_image_3,Properties.Resources.lvl2_m_image_4,
            Properties.Resources.lvl2_m_image_5,Properties.Resources.lvl2_m_image_6,
            Properties.Resources.lvl2_m_image_7,Properties.Resources.lvl2_m_image_8,
            Properties.Resources.lvl2_m_image_9,Properties.Resources.lvl2_m_image_10,
            Properties.Resources.lvl2_m_image_11,Properties.Resources.lvl2_m_image_12,
            Properties.Resources.lvl2_m_image_13,Properties.Resources.lvl2_m_image_14,
            Properties.Resources.lvl2_m_image_15,Properties.Resources._null,
            Properties.Resources.lvl2_m_image_16});
                indx = 2;
            }

            else if (q == "puzzle3")
            {
                original_img.Image = Properties.Resources.puzzle3;
                original_image_list.AddRange(new Bitmap[]
                {Properties.Resources.lvl3_m_image_1,Properties.Resources.lvl3_m_image_2,
            Properties.Resources.lvl3_m_image_3,Properties.Resources.lvl3_m_image_4,
            Properties.Resources.lvl3_m_image_5,Properties.Resources.lvl3_m_image_6,
            Properties.Resources.lvl3_m_image_7,Properties.Resources.lvl3_m_image_8,
            Properties.Resources.lvl3_m_image_9,Properties.Resources.lvl3_m_image_10,
            Properties.Resources.lvl3_m_image_11,Properties.Resources.lvl3_m_image_12,
            Properties.Resources.lvl3_m_image_13,Properties.Resources.lvl3_m_image_14,
            Properties.Resources.lvl3_m_image_15,Properties.Resources._null,
            Properties.Resources.lvl3_m_image_16});
                indx = 3;
            }

            else if (q == "puzzle4")
            {
                original_img.Image = Properties.Resources.puzzle4;
                original_image_list.AddRange(new Bitmap[]
                {Properties.Resources.lvl4_m_image_1,Properties.Resources.lvl4_m_image_2,
            Properties.Resources.lvl4_m_image_3,Properties.Resources.lvl4_m_image_4,
            Properties.Resources.lvl4_m_image_5,Properties.Resources.lvl4_m_image_6,
            Properties.Resources.lvl4_m_image_7,Properties.Resources.lvl4_m_image_8,
            Properties.Resources.lvl4_m_image_9,Properties.Resources.lvl4_m_image_10,
            Properties.Resources.lvl4_m_image_11,Properties.Resources.lvl4_m_image_12,
            Properties.Resources.lvl4_m_image_13,Properties.Resources.lvl4_m_image_14,
            Properties.Resources.lvl4_m_image_15,Properties.Resources._null,
            Properties.Resources.lvl4_m_image_16});
                indx = 4;
            }
            else if (q == "puzzle5")
            {
                original_img.Image = Properties.Resources.puzzle5;
                original_image_list.AddRange(new Bitmap[]
                {Properties.Resources.lvl5_m_image_1,Properties.Resources.lvl5_m_image_2,
            Properties.Resources.lvl5_m_image_3,Properties.Resources.lvl5_m_image_4,
            Properties.Resources.lvl5_m_image_5,Properties.Resources.lvl5_m_image_6,
            Properties.Resources.lvl5_m_image_7,Properties.Resources.lvl5_m_image_8,
            Properties.Resources.lvl5_m_image_9,Properties.Resources.lvl5_m_image_10,
            Properties.Resources.lvl5_m_image_11,Properties.Resources.lvl5_m_image_12,
            Properties.Resources.lvl5_m_image_13,Properties.Resources.lvl5_m_image_14,
            Properties.Resources.lvl5_m_image_15,Properties.Resources._null,
            Properties.Resources.lvl5_m_image_16});
                indx = 5;
            }
            else if (q == "puzzle6")
            {
                original_img.Image = Properties.Resources.puzzle6;
                original_image_list.AddRange(new Bitmap[]
                {Properties.Resources.lvl6_m_image_1,Properties.Resources.lvl6_m_image_2,
            Properties.Resources.lvl6_m_image_3,Properties.Resources.lvl6_m_image_4,
            Properties.Resources.lvl6_m_image_5,Properties.Resources.lvl6_m_image_6,
            Properties.Resources.lvl6_m_image_7,Properties.Resources.lvl6_m_image_8,
            Properties.Resources.lvl6_m_image_9,Properties.Resources.lvl6_m_image_10,
            Properties.Resources.lvl6_m_image_11,Properties.Resources.lvl6_m_image_12,
            Properties.Resources.lvl6_m_image_13,Properties.Resources.lvl6_m_image_14,
            Properties.Resources.lvl6_m_image_15,Properties.Resources._null,
            Properties.Resources.lvl6_m_image_16});
                indx = 6;
            }
        }

        private void picture_box_shift(object sender, EventArgs e)
        {
            if (tm.Text == "00:00:00")
            {
                timer.Start();
            }

            int x = 0, y = 0, z = 0, v = 0;
            int current_image_index = groupBox1.Controls.IndexOf(sender as Control);

            if (current_image_index != null_img_index)
            {
                if (current_image_index == 0)
                {
                    x = current_image_index + 1;
                    y = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 1)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 2)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 3)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 4)
                {
                    x = current_image_index - 4;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 5)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    v = current_image_index - 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index || v == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 6)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    v = current_image_index - 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index || v == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 7)
                {
                    x = current_image_index - 1;
                    y = current_image_index - 4;
                    z = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 8)
                {
                    x = current_image_index - 4;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }

                }
                else if (current_image_index == 9)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    v = current_image_index - 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index || v == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 10)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index + 4;
                    v = current_image_index - 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index || v == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 11)
                {
                    x = current_image_index - 1;
                    y = current_image_index - 4;
                    z = current_image_index + 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 12)
                {
                    x = current_image_index - 4;
                    y = current_image_index + 1;
                    if (x == null_img_index || y == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 13)
                {
                    x = current_image_index - 1;
                    y = current_image_index + 1;
                    z = current_image_index - 4;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 14)
                {
                    x = current_image_index - 4;
                    y = current_image_index - 1;
                    z = current_image_index + 1;
                    if (x == null_img_index || y == null_img_index
                        || z == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }
                else if (current_image_index == 15)
                {
                    x = current_image_index - 1;
                    y = current_image_index - 4;
                    if (x == null_img_index || y == null_img_index)
                    {
                        ((PictureBox)groupBox1.Controls[null_img_index]).Image = ((PictureBox)groupBox1.Controls[current_image_index]).Image;
                        ((PictureBox)groupBox1.Controls[current_image_index]).Image = original_image_list[15];
                        null_img_index = current_image_index;
                        m++;
                        moves.Text = m.ToString();
                    }
                }

                if (win_check())
                {
                    (groupBox1.Controls[15] as PictureBox).Image = original_image_list[16];
                    timer.Reset();
                    tm.Text = "00:00:00";
                    MessageBox.Show("Congrats You have solved the puzzle\n Total no. of moves made are:" + moves.Text);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string hg = "";
                        string query = "select * from highscore_m where username=@username";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@username", user.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        DataColumn col = ds.Tables[0].Columns[indx];
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            hg = row[col].ToString();
                        }
                        if (string.IsNullOrEmpty(hg))
                        {
                            //no previous high score for the current puzzle
                            query = "update highscore_m set " + pzl_n + "=@hg where username=@username";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@username", user.Text);
                            cmd.Parameters.AddWithValue("@hg", m);
                            cmd.ExecuteNonQuery();
                        }
                        else if (m < int.Parse(hg))
                        {
                            //repace the previous high score with the curent high score
                            query = "update highscore_m set " + pzl_n + "=@hg where username=@username";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@username", user.Text);
                            cmd.Parameters.AddWithValue("@hg", m);
                            cmd.ExecuteNonQuery();
                        }

                    }
                    con.Close();
                    m = 0;
                    moves.Text = m.ToString();
                    //ask do you wnat to restart
                    DialogResult YesOrNO = MessageBox.Show("Do you want to restart ?", "Puzzle solved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (YesOrNO == DialogResult.No)
                    {
                        //Application.Exit();
                        //puzzle_select pz = new puzzle_select(user.Text);
                        //this.Hide();
                        //pz.Show();
                        this.Close();
                    }
                    if (YesOrNO == DialogResult.Yes)
                    {
                        shuffel();
                    }

                }

            }


        }

        private void shuffel()
        {
            moves.Text = 0.ToString();
            bool shf;
            do
            {
                //bool shf = true;
                int inversion_count = 0;
                List<int> inversion = new List<int>();
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
                Random r = new Random();
                for (int i = 0; i < 16; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)groupBox1.Controls[i]).Image = original_image_list[j];
                    //inversion.Add(j);
                    if (j == 15)
                    {
                        null_img_index = i;
                    }
                    else
                    {
                        inversion.Add(j);
                    }

                }
                for (int y = 0; y < inversion.Count; y++)
                {
                    for (int x = y + 1; x < inversion.Count; x++)
                    {
                        if (inversion[y] > inversion[x])
                        {
                            inversion_count++;
                        }
                    }
                }

                //in which row is null present
                int row = 0;
                int temp = 0;
                for (int i = 0; i < 16; i++)
                {
                    if (i == null_img_index)
                    {
                        temp = null_img_index;
                        break;
                    }
                }

                if (temp >= 0 && temp <= 3)
                {
                    //row4
                    row = 4;
                }
                else if (temp >= 4 && temp <= 7)
                {
                    //row3
                    row = 3;
                }
                else if (temp >= 8 && temp <= 11)
                {
                    //row2
                    row = 2;
                }

                else if (temp >= 12 && temp <= 15)
                {
                    //row1
                    row = 1;
                }

                //puzzle is solveable if
                //he blank is on an even row counting from
                //the bottom (second - last, fourth - last, etc.)
                //and number of inversions is odd.
                //the blank is on an odd row counting from
                //the bottom (last, third-last, fifth - last, etc.)
                //and number of inversions is even.

                if (row % 2 == 0 && inversion_count % 2 != 0)
                {
                    //solveable
                    shf = false;
                }
                else if (row % 2 != 0 && inversion_count % 2 == 0)
                {
                    //solveable
                    shf = false;
                }
                else
                {
                    //not solveable
                    shf = true;
                }

            } while (win_check() || shf == true);
        }



        private void puzzle_m_Load(object sender, EventArgs e)
        {
            shuffel();
        }
        private bool win_check()
        {
            int i;
            for (i = 0; i < 15; i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != original_image_list[i])
                {
                    break;
                }
            }
            if (i == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
            {
                tm.Text = timer.Elapsed.ToString().Remove(8);
            }
            if (timer.Elapsed.Minutes.ToString() == "2")
            {
                timer.Reset();
                moves.Text = "0";
                tm.Text = "00:00:00";
                m = 0;
                MessageBox.Show("Time Is Up\nTry Again");
                shuffel();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Disable Time")
            {
                timer.Stop();
                button1.Text = "Enable Time";
            }
            else if (button1.Text == "Enable Time")
            {
                button1.Text = "Disable Time";
                timer.Reset();
                m = 0;
                moves.Text = m.ToString();
                tm.Text = "00:00:00";
                shuffel();
            }
        }

        private void shufl_Click(object sender, EventArgs e)
        {
            m = 0;
            moves.Text = m.ToString();
            timer.Reset();
            tm.Text = "00:00:00";
            shuffel();
        }
    }
}
