using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//5-1-a-s-p-x
namespace ATMManager
{
    public partial class Main : Form
    {
        public static Main main;
        public static Card currentCard = null;
        public Main()
        {
            InitializeComponent();
            main = this;
        }

        private void buttonColorSet1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            ButtonColorSet button = ((ButtonColorSet)sender);
            button.BackColor = Color.YellowGreen;

        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ButtonColorSet button = ((ButtonColorSet)sender);

            button.BackColor = Color.LightGray;

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonColorSet2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public static int num = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            if (num > 5) num = 1;
            switch (num)
            { 
            
                case 1:
                    this.pictureBox1.Image = global::ATMManager.Properties.Resources._1;
                    break;
                case 2:
                    this.pictureBox1.Image = global::ATMManager.Properties.Resources._2;
                    break;
                case 3:
                    this.pictureBox1.Image = global::ATMManager.Properties.Resources._3;
                    break;
                case 4:
                    this.pictureBox1.Image = global::ATMManager.Properties.Resources._4;
                    break;
                case 5:
                    this.pictureBox1.Image = global::ATMManager.Properties.Resources._5;
                    break;
                default :
                    this.pictureBox1.Image = global::ATMManager.Properties.Resources._1;
                    break;

            }
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}