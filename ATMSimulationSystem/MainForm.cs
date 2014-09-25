using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class MainForm : Form
    {
        public static MainForm main;
        public MainForm( string num)
        {
            AboutBox1 aboutBox = new AboutBox1();

            aboutBox.Show();
            aboutBox.Activate();
            Application.DoEvents();
            System.Threading.Thread.Sleep(5000);
            aboutBox.Close();
            aboutBox.Dispose();

            
            InitializeComponent();
            this.cardNum.Text = num;
            main = this;
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

        private void buttons_Click(object sender, EventArgs e)
        {
          
              ButtonColorSet button = ((ButtonColorSet)sender);
              switch (button.Name)
              {
                  case "b1":
                      new TransfAccount(Main.currentCard.CardNum).Show();
                      this.Hide();
                      break;
                  case "b2":
                      new CheckBalance(Main.currentCard.CardNum).Show();
                      this.Hide();
                      break;
                  case "b3":
                      new Update(Main.currentCard.CardNum).Show();
                      this.Hide();
                      break;
                  case "b4":
                      new Enchashment(Main.currentCard.CardNum).Show();
                      this.Hide();

                      break;
                  case "b6":
                      this.Close();
                      Main.main.Show();
                      MessageBox.Show(" Thanks for this transaction，please take your card！", "ATM notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      break;
              }
             

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}