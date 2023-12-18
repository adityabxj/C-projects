using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numPadButton_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Numpad key Pressed";
        }

        private void alphabetButton_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "Alpha key Pressed";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D5)
            {
                numPadButton.PerformClick();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numberLabel.Text = "Alpha key Pressed";
            }
        }
    }
}
