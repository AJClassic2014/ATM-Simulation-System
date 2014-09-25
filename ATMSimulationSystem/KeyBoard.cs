using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ATMManager
{
    public partial class KeyBoard1 : UserControl
    {
        public KeyBoard1()
        {
            InitializeComponent();
            labels.Add(this.a1);
            labels.Add(this.a2);
            labels.Add(this.a3);
            labels.Add(this.a4);
            labels.Add(this.a5);
            labels.Add(this.a6);
            labels.Add(this.a7);
            labels.Add(this.a8);
            labels.Add(this.a9);
            labels.Add(this.a0);
            labels.Add(this.a00);
            this.a1.Location = new System.Drawing.Point(20, 25);
            this.a2.Location = new System.Drawing.Point(69, 25);
            this.a3.Location = new System.Drawing.Point(115, 25);
            this.a4.Location = new System.Drawing.Point(20, 74);
            this.a5.Location = new System.Drawing.Point(69, 74);
            this.a6.Location = new System.Drawing.Point(115, 74);

            this.a7.Location = new System.Drawing.Point(20, 123);
            this.a8.Location = new System.Drawing.Point(69, 123);
            this.a9.Location = new System.Drawing.Point(115, 123);
            this.a0.Location = new System.Drawing.Point(161, 25);
            this.a00.Location = new System.Drawing.Point(161, 74);

            this.aa.Location = new System.Drawing.Point(207, 74);
            this.ab.Location = new System.Drawing.Point(207, 123);
            this.a000.Location = new System.Drawing.Point(161, 123);



      }
        public List<PointItem> points = new List<PointItem>();
        public List<Label> labels = new List<Label>();

        public void changeKey()
        {
            points.Clear();
            for (int i = 0; i < 11; i++)
            {
                PointItem item = new PointItem();
                item.index = i;
                int va = i % 4 * 40 + 20;
                int vb = i / 4 * 40 + 20;
                item.point = new Point(va, vb);
                points.Add(item);
            }
            if (points.Count <= 0) return;
            Random random = new Random();
            int index =0;
            for (int i = 0; i < labels.Count; i++)
            {
                index = random.Next(0, points.Count);
                labels[i].Location=points[index].point;
                points.RemoveAt(index);
            }

        }
        public TextBox cTextBox = null;
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Label button = ((Label)sender);
            button.BackColor = Color.YellowGreen;

        }


        private void button_MouseLeave(object sender, EventArgs e)
        {
            Label button = ((Label)sender);
            button.BackColor = SystemColors.Control;
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Label button = ((Label)sender);
            if (cTextBox == null) return;

            switch (button.Name)
            {
                case "a0": cTextBox.Text += "0"; break;
                case "a1": cTextBox.Text += "1"; break;
                case "a2": cTextBox.Text += "2"; break;
                case "a3": cTextBox.Text += "3"; break;
                case "a4": cTextBox.Text += "4"; break;
                case "a5": cTextBox.Text += "5"; break;
                case "a6": cTextBox.Text += "6"; break;
                case "a7": cTextBox.Text += "7"; break;
                case "a8": cTextBox.Text += "8"; break;
                case "a9": cTextBox.Text += "9"; break;
                case "a00": cTextBox.Text += "00"; break;
                case "a000": cTextBox.Text += "."; break;
                case "aa":
                    if (cTextBox.Text.Length == 0)
                        cTextBox.Text = "";
                    else
                        cTextBox.Text = cTextBox.Text.Substring(0, cTextBox.Text.Length - 1);
                    break;
                case "ab": cTextBox.Text = ""; break;
                default: break;
            }

            cTextBox.SelectionStart = cTextBox.Text.Length;
        }

        private void KeyBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
