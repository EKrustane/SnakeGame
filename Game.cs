﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {
        int horVelocity = 0;
        int verVelocity = 0;
        int step = 20;

        Area area = new Area();
        Snake snake = new Snake();
        Timer mainTimer = new Timer();
        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeTimer()
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

        }
        private void InitializeGame()
        {
            this.Height = 600;
            this.Width = 600;
            this.Controls.Add(area);
            area.Top = 80;
            area.Left = 80;

            //adding snake body
            snake.Render(this);
        }
    }
}
