using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class CheckBalance : Form
    {
        public CheckBalance(string¡¡num)
        {
            InitializeComponent();
            this.cardNum.Text = num;
            this.acount.Text = bell.searchAccountByID(Main.currentCard.Id);
            this.acount.SelectionStart = 0;
            List<string> operationList=bell.getCardOperation(num);
            foreach (string operationDetails in operationList)
            {
                if (operationDetails != "")
                    this.listBox1.Items.Add(operationDetails);
            }

        }
        public CardManagerBLL bell = new CardManagerBLL();
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
                case "b3":
                    this.Close();
                    if (MainForm.main != null)
                        MainForm.main.Show();
                    break;
                case "b4":
                    this.Close();
                    Main.main.Show();
                    MessageBox.Show(" Thanks for this transaction£¬please take your card£¡", "ATM notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {
            
        }

        private void cardNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
    }
}