using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void txtHo_TextChanged(object sender, EventArgs e){ }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHo_Click(object sender, EventArgs e)
        {
            Text = txtHo.Text;
            //string[] arr= Text.Split(' ');
            //txtHo.Text = arr[0];
            //txtHo.Text = arr[1];
            lblHoTen.Text = txtHo.Text;
        }
        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text += " " + txtTen.Text;
        }
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            Text = txtHo.Text;
            string[] arr = Text.Split(' ');
            lblHoTen.Text = txtHo.Text;
            lblHoTen.Text = txtHo.Text +" "+ txtTen.Text;
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
            txtHo.Clear();
            txtTen.Clear();
            txtHo.Focus();
        }
    }
}
