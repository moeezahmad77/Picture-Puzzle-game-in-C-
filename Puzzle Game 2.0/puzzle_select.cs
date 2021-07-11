using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Game_2._0
{
    public partial class puzzle_select : Form
    {
        string q;
        public puzzle_select(string un)
        {
            InitializeComponent();
            user.Text = un;
        }

        private void puzzle1_Click(object sender, EventArgs e)
        {
            q = puzzle1.Name;
            if(radioButton1.Checked==true)
            {
                puzzle_e p = new puzzle_e(q,user.Text);
                p.ShowDialog();
            }
            else if(radioButton2.Checked==true)
            {
                puzzle_m pm = new puzzle_m(q, user.Text);
                pm.ShowDialog();
            }
        }

        private void puzzle2_Click(object sender, EventArgs e)
        {
            q = puzzle2.Name;
            if (radioButton1.Checked == true)
            {
                puzzle_e p = new puzzle_e(q, user.Text);
                p.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                puzzle_m pm = new puzzle_m(q, user.Text);
                pm.ShowDialog();
            }
        }

        private void puzzle3_Click(object sender, EventArgs e)
        {
            q = puzzle3.Name;
            if (radioButton1.Checked == true)
            {
                puzzle_e p = new puzzle_e(q, user.Text);
                p.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                puzzle_m pm = new puzzle_m(q, user.Text);
                pm.ShowDialog();
            }
        }

        private void puzzle4_Click(object sender, EventArgs e)
        {
            q = puzzle4.Name;
            if (radioButton1.Checked == true)
            {
                puzzle_e p = new puzzle_e(q, user.Text);
                p.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                puzzle_m pm = new puzzle_m(q, user.Text);
                pm.ShowDialog();
            }
        }

        private void puzzle5_Click(object sender, EventArgs e)
        {
            q = puzzle5.Name;
            if (radioButton1.Checked == true)
            {
                puzzle_e p = new puzzle_e(q, user.Text);
                p.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                puzzle_m pm = new puzzle_m(q, user.Text);
                pm.ShowDialog();
            }
        }

        private void puzzle6_Click(object sender, EventArgs e)
        {
            q = puzzle6.Name;
            if (radioButton1.Checked == true)
            {
                puzzle_e p = new puzzle_e(q, user.Text);
                p.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                puzzle_m pm = new puzzle_m(q, user.Text);
                pm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Highscore_individual h = new Highscore_individual(user.Text);
            h.ShowDialog();
        }
    }
}
