using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScrabbleScorer
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void cmdScore_Click(object sender, EventArgs e)
        {
            int wordScore = Calculator.WordValue(txtWord.Text);

            lblScore.Text = wordScore.ToString();
        }

        private void cmdDouble_Click(object sender, EventArgs e)
        {
            int wordScore = 2 * Calculator.WordValue(txtWord.Text);

            lblScore.Text = wordScore.ToString();
        }

        private void cmdTriple_Click(object sender, EventArgs e)
        {
            int wordScore = 3 * Calculator.WordValue(txtWord.Text);

            lblScore.Text = wordScore.ToString();
        }

    }
}
