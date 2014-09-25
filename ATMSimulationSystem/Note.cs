using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
namespace ATMManager
{
    public partial class Note : Form
    {
        public Note(string item)
        {
            InitializeComponent();
            this.label1.Text = item;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Note_Load(object sender, EventArgs e)
        {

        }
    }
}//