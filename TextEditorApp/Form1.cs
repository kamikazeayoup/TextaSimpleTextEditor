using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            exitbtn.Click += (sender, e) => this.Close();
            dlgopen.Filter = "Rich Text Files |*.rtf|Text Files|*.txt";
            dlgsave.Filter = "Rich Text Files |*.rtf|Text Files|*.txt";

        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                switch (dlgopen.FilterIndex)
                {
                    case 1:
                        richtxt.LoadFile(dlgopen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        richtxt.LoadFile(dlgopen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            if (dlgcolor.ShowDialog() == DialogResult.OK)
            {
                richtxt.SelectionColor = dlgcolor.Color;
            }
        }

        private void fontbtn_Click(object sender, EventArgs e)
        {
            if (dlgfont.ShowDialog() == DialogResult.OK)
            {
                richtxt.SelectionFont = dlgfont.Font;

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (dlgsave.ShowDialog() == DialogResult.OK)
            {
                switch (dlgsave.FilterIndex)
                {
                    case 1:
                        richtxt.SaveFile(dlgsave.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        richtxt.SaveFile(dlgsave.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            richtxt.Clear();
        }
    }
}
