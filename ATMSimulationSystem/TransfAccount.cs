using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class TransfAccount : Form
    {
        public TransfAccount(string num )
        {
            InitializeComponent();
            this.label3.Text = num;

            List<string> carList = bell.searchCardNum();
            foreach (string cardItem in carList)
            {
                if (cardItem != "")
                    this.cardNum.Items.Add(cardItem);
            }
            if (this.cardNum.Items.Count >= 1)
                this.cardNum.SelectedIndex = 0;
            this.acount.Focus();
            this.keyBoard1.cTextBox = this.acount;
            this.keyBoard1.changeKey();
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
        public CardManagerBLL bell = new CardManagerBLL();
        private void buttons_Click(object sender, EventArgs e)
        {
            ButtonColorSet button = ((ButtonColorSet)sender);
            switch (button.Name)
            {
                case "b1":
                    if (this.cardNum.Items.Count >= 1)
                        this.cardNum.SelectedIndex = 0;
                    this.acount.Text = "";
                    break;
                case "b2":
                    TransfAccountControler(this.cardNum.Text);
                    break;
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
        public string note = "";

        public void TransfAccountControler(string cardNum)
        {
            Card subCard = bell.searchCardByCardNum(cardNum);

            if (subCard == null)
            {
                MessageBox.Show("The transfered card number does not exist, please input again£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cardNum.Focus();
                return;
            }

            if (subCard.Id == Main.currentCard.Id)
            {
                MessageBox.Show("Transfer into the same card number, please enter again!£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.acount.Text = "";
                return;
            }
             float EnchashValue = 0;
             float.TryParse(this.acount.Text, out EnchashValue);
            if (EnchashValue <= 0)
            {
                MessageBox.Show("The transfer amount must be greater than zero£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.acount.Text = "";
                return;
           }
            float balance = Main.currentCard.Acount - (float)EnchashValue;
            if (balance < 0.0f)
            {
                MessageBox.Show("The operation failed, on your card balance is insufficient, please re - enter the amount of money£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.acount.Text = "";
                return;
            }

            MessageBox.Show("Please confirm whether the transfer£¿", "ATM Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            float balance2 = subCard.Acount + (float)EnchashValue;
            if (bell.updateAccountByID(Main.currentCard.Id, balance) && bell.updateAccountByID(subCard.Id, balance2) && bell.updateAccountOperationByCardNum(Main.currentCard.CardNum, (float)EnchashValue, "transfer to " + subCard.CardNum) && bell.updateAccountOperationByCardNum(subCard.CardNum, (float)EnchashValue, "accept from " + Main.currentCard.CardNum))
            {

                DialogResult re = MessageBox.Show("Transfer success, whether to print a receipt£¿", "ATM Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (re == DialogResult.Yes)
               {
                   note = "Operation£º  transfer \r\n\r\n";
                   note += "Card Number£º " + Main.currentCard.CardNum + "\r\n\r\n";
                   note += "transfered card Number£º " + subCard.CardNum + "\r\n\r\n";
                   note += "Amount£º " + EnchashValue.ToString() + "\r\n\r\n";
                   note += " Thanks£¡";
                   new Note(note).Show();
               }
            }
            //if (this.cardNum.Items.Count >= 1)
            //    this.cardNum.SelectedIndex = 0;
            this.acount.Text = "";
        }

        private void acount_Enter(object sender, EventArgs e)
        {
            this.keyBoard1.cTextBox = this.acount;
            this.keyBoard1.changeKey();
        }

        private void acount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cardNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void keyBoard1_Load(object sender, EventArgs e)
        {

        }

        private void TransfAccount_Load(object sender, EventArgs e)
        {

        }
    }
}