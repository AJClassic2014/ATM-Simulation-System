using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            List<string> carList = cardBll.searchCardNum();
            foreach (string cardItem in carList)
            {
                if (cardItem != "")
                    this.cardNum.Items.Add(cardItem);
            }
            if (this.cardNum.Items.Count >= 1)
                this.cardNum.SelectedIndex = 0;
            this.password.Focus();
            this.keyBoard1.cTextBox = this.password;
            this.keyBoard1.changeKey();

        }
        public CardManagerBLL cardBll = new CardManagerBLL();

        private void buttonColorSet4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.main.Show();
            MessageBox.Show(" Thanks for this transaction£¬please take your card£¡", "ATM notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void buttonColorSet5_Click(object sender, EventArgs e)
        {
            //card number information confirm
          if("".Equals(this.cardNum.Text))
          {
              MessageBox.Show("Please enter your card number£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
          }
          if ("".Equals(this.password.Text))
          {
              MessageBox.Show("Please enter your password!", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.password.Focus();
              return;
          }
            Main.currentCard=cardBll.Login(this.cardNum.Text,this.password.Text);

            if (Main.currentCard == null)
            {
                MessageBox.Show("You enter the card number or password is wrong, please input again!", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.password.Focus();                
                return;
            }
            this.Close();
            new MainForm(Main.currentCard.CardNum).Show();
        }

        private void password_Enter(object sender, EventArgs e)
        {
            this.keyBoard1.cTextBox = this.password;
            this.keyBoard1.changeKey();
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}