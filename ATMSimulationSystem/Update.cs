using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class Update : Form
    {
        public Update(string num)
        {
            InitializeComponent();
            this.cardNum.Text = num;
            this.keyBoard1.cTextBox = this.old;
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

        private void b3_Click(object sender, EventArgs e)
        {
            ButtonColorSet button = ((ButtonColorSet)sender);
            switch (button.Name)
            {
                case "b1":
                    this.new1.Text = "";
                    this.new2.Text = "";
                    this.old.Text = "";
                    break;
                case "b2":
                    update();
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
        public CardManagerBLL bell = new CardManagerBLL();
        public void update()
        {
            if (this.old.Text == "")
            {
                MessageBox.Show("Password can not be empty£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.new1.Text == ""||this.new2.Text == "")
            {
                MessageBox.Show("New Password can not be empty£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!this.new1.Text.Equals(this.new2.Text))
            {
                MessageBox.Show("Confirm password is not correct£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!this.old.Text.Equals(Main.currentCard.Password))
            {
                MessageBox.Show("You enter the original password is not correct£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.new1.Text.Length!=6)
            {
                MessageBox.Show("Bank card password is 6, please input again£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.new1.Text = "";
                this.new2.Text = "";
                this.new1.Focus();
                return;
            }
            if (bell.updatePassword(Main.currentCard.Id, this.new1.Text))
            {
                MessageBox.Show("Change password successfully£¡", "ATM Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.new1.Text = "";
                this.new2.Text = "";
                this.old.Text = "";
            }
    
        }
//5-1-a-s-p-x
        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void new2_Enter(object sender, EventArgs e)
        {
            this.keyBoard1.cTextBox = (TextBox)sender;
            this.keyBoard1.changeKey();
        }

        private void new2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cardNum_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}