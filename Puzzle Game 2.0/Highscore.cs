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
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puzzleDataSet1.highscore_m' table. You can move, or remove it, as needed.
            this.highscore_mTableAdapter.Fill(this.puzzleDataSet1.highscore_m);
            // TODO: This line of code loads data into the 'puzzleDataSet.highscore_e' table. You can move, or remove it, as needed.
            this.highscore_eTableAdapter.Fill(this.puzzleDataSet.highscore_e);

        }
    }
}
