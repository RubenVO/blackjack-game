﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerController player1 = new PlayerController();
            PlayerBetController bet = new PlayerBetController(player1);
            Controls.Add(player1.getView());
            Controls.Add(bet.getView());


        }
    }
}
