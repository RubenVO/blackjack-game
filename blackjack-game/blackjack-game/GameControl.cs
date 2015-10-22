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
    public partial class GameControl : Form
    {
        public GameControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init
            PlayerController player1 = new PlayerController();
            PlayerBetController bet = new PlayerBetController(player1);
            StartResetController startReset = new StartResetController();
            

            //add
            Controls.Add(player1.getView());
            Controls.Add(bet.getView());
            Controls.Add(startReset.getView());

            //pos for bet view
            int yPosBet = 0;
            yPosBet = player1.getView().Height;
            bet.getView().Location = new Point(0, yPosBet);

            //pos for start reset view
            int xPosStart = 0;
            xPosStart = player1.getView().Width;
            startReset.getView().Location = new Point(xPosStart, 0); 

        }
    }
}