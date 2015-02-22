using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Speed_Test
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        public void timesUp(int score, String details) {
            this.Text = "Time's Up!";
            scoreLabel.Text = "You got " + score + " correct.";
            detailsLabel.Text = details;
        }

        public void finished(int score, String details)
        {
            this.Text = "You finished!";
            scoreLabel.Text = "You got " + score + " correct.";
            detailsLabel.Text = details;
        }

      
    }
}
