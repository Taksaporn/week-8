﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        public void show_score(string score) {
            lblScore.Text = score;
        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
