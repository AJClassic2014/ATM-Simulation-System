using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class Enchashment : Form
    {
        public Enchashment(string num)
        {
            InitializeComponent();
            this.cardNum.Text = num;
            this.acount.Focus();
            this.keyBoard1.cTextBox = this.acount;
            this.keyBoard1.changeKey();
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
        public int EnchashValue = 0;
        private void buttons_Click(object sender, EventArgs e)
        {
            ButtonColorSet button = ((ButtonColorSet)sender);
            switch (button.Name)
            {
                case "b1":
                     this.acount.Text = getData(this.acount.Text,100);
                    break;
                case "b2":
                    this.acount.Text = getData(this.acount.Text,200);
                    break;

                case "b3":
                    this.acount.Text = getData(this.acount.Text,500);
                    break;
               
                case "b5":
                    EnchashmentControler();
                    break;
                
                case "b4":
                    this.Close();
                    if (MainForm.main != null)
                        MainForm.main.Show();
                    break;
                case "b6":
                    this.Close();
                    Main.main.Show();
                    MessageBox.Show(" Thanks for this transaction£¬please take your card£¡", "ATM notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        public string note = "";

        public void EnchashmentControler()
        {
            EnchashValue = 0;
            int.TryParse(this.acount.Text, out EnchashValue);
            if (EnchashValue <= 0)
            {
                MessageBox.Show("The amount of money or value is not correct, please input again!", "ATM Remind", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.acount.Text = "";
                return;
            }
            if (EnchashValue % 100!=0)
            {
                MessageBox.Show("Par value is 100, please select the desirable amount", "ATM Remind", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.acount.Text = "";
                return;
            }
            if(Main.currentCard==null)
            {
                MessageBox.Show("The operation failed, please re login account£¡", "ATM Remind", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            new Login().Show();
                return;
            }

            float balance=Main.currentCard.Acount-(float)EnchashValue;
            if(balance<=0.0f)
            {
                MessageBox.Show("The operation failed, on your card balance is insufficient, please re select the amount of money£¡", "ATM Remind", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.acount.Text = "";
              return;
            }

            if (bell.updateAccountByID(Main.currentCard.Id, balance) && bell.updateAccountOperationByCardNum(Main.currentCard.CardNum, (float)EnchashValue, "withdraw"))
            {
                DialogResult re = MessageBox.Show("Please take away your money, whether to print a receipt£¿", "ATM Remind", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (re == DialogResult.Yes)
               {
                   note = "Operation£º  withdraw \r\n\r\n";
                   note += "Card Number£º " + Main.currentCard.CardNum + "\r\n\r\n";
                   note += "Amount£º " + EnchashValue.ToString() + "\r\n\r\n";
                   note += " Thanks£¡";
                   new Note(note).Show();
               }
           }
   
        }

        public  string getData(string value,int data)
        {
            EnchashValue = 0;
            if ("".Equals(value))
                EnchashValue = data;
            else
            {
                int.TryParse(value, out EnchashValue);
                EnchashValue += data;
            }
            return EnchashValue.ToString();
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

        private void Enchashment_Load(object sender, EventArgs e)
        {

        }
    }
}