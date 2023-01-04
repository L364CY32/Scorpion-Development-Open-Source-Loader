using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class Spoofers : Form
    {
        public Spoofers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }
        Point lastpoint;
        private void SpooferForm_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastpoint = new Point(e.X, e.Y);
            }
        }

        private void SpooferForm_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastpoint.X;
                    this.Top += e.Y - lastpoint.Y;
                }
            }
        }
        private void SpoofFortniteButton_Click(object sender, EventArgs e)
        {
            Download.LoadFortniteSpoofer();
        }
        private void SpoofMACButton_Click(object sender, EventArgs e)
        {
            Download.LoadMACSpoofer();
        }
        private void SerialcheckerButton_Click(object sender, EventArgs e)
        {
            Download.LoadSerialChecker();
        }

        private void SpooferForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
