﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dua_xe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            linemove(carspeed);
            gameover();
            totalscore();
            
        }
        Random pos = new Random();
        void linemove(int speed)
        {
            if (pictureBox1.Top > 500) pictureBox1.Top = 0;
            else pictureBox1.Top += speed;
            if (pictureBox2.Top > 500) pictureBox2.Top = 0;
            else pictureBox2.Top += speed;
            if (pictureBox3.Top > 500) pictureBox3.Top = 0;
            else pictureBox3.Top += speed;
            if (enemy1.Top > 500)
            {
                score++;
                enemy1.Left = pos.Next(0, 200);
                enemy1.Top = pos.Next(0, 40);
                enemy1.Top = 0;
            }
            else enemy1.Top += speed;
            if (enemy2.Top > 500)
            {
                score++;
                enemy2.Left = pos.Next(0, 200);
                enemy2.Top = pos.Next(0, 40);
                enemy2.Top = 0;
            }
            else enemy2.Top += speed;
            if (enemy3.Top > 500)
            {
                score++;
                enemy3.Left = pos.Next(225, 300);
                enemy3.Top = pos.Next(0, 40);
                enemy3.Top = 0;
            }
            else enemy3.Top += speed;
            if (enemy4.Top > 500)
            {
                score++;
                enemy4.Left = pos.Next(225, 300);
                enemy4.Top = pos.Next(0, 40);
                enemy4.Top = 0;
            }
            else enemy4.Top += speed;
        }
        int carspeed = 3;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left > 0) mycar.Left -= 3;
            if (e.KeyCode == Keys.Right && mycar.Left < 300) mycar.Left += 3;
            if (e.KeyCode == Keys.Up && carspeed < 30) carspeed++;
            if (e.KeyCode == Keys.Down && carspeed > 3) carspeed--;
        }
        int score;
        void totalscore()
        {
            textBox1.Text = score.ToString();
        }
        void gameover()
        {
            if (mycar.Bounds.IntersectsWith(enemy1.Bounds))

            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Bạn muốn chơi lại", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = pos.Next(0, 200);
                        enemy1.Top = 0;
                        enemy2.Left = pos.Next(0, 200);
                        enemy2.Top = 0;
                        enemy3.Left = pos.Next(225, 300);
                        enemy3.Top = 0;
                        enemy4.Left = pos.Next(225, 300);
                        enemy4.Top = 0;
                        score = 0;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        this.Close();
                        break;
                }


            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void mycar_Click(object sender, EventArgs e)
        {

        }
    }
}
