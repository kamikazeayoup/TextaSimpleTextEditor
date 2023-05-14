using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void OpacityResize(object sender, EventArgs e)
        {
            this.Opacity = 0.8;

        }

        private void OpacityEndResize(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Convert.ToString(DateTime.Now));
            HomForm nw = new HomForm();
            this.Hide();
            nw.ShowDialog();
            this.Close();


        }

        private void ok_btn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure that you want to exit ? "  ,
                "Warning" , MessageBoxButtons.YesNo ,
                MessageBoxIcon.Warning ,
                MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
