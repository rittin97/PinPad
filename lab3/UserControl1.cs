using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class UserControl1 : UserControl
    {
        public static int counter = 0;
        public UserControl1()
        {
            InitializeComponent();
            txtBox.MaxLength = 6;
            txtBox.PasswordChar = '*';
            this.ActiveControl = txtBox;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 6)
                txtBox.Text += '0';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter < )
        }
    }
}
