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
    public partial class Cleaners : Form
    {
        public Cleaners()
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
        private void CleanerForm_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastpoint = new Point(e.X, e.Y);
            }
        }

        private void CleanerForm_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastpoint.X;
                    this.Top += e.Y - lastpoint.Y;
                }
            }
        }
        private void CleanapexButton_Click(object sender, EventArgs e)
        {
            Download.Loadapexcleaner();
        }

        private void CleanEACButton_Click(object sender, EventArgs e)
        {
            Download.LoadEACcleaner();
        }

        private void CleanR6SButton_Click(object sender, EventArgs e)
        {
            Download.LoadR6Scleaner();
        }

        private void CleanValorantButton_Click(object sender, EventArgs e)
        {
            Download.LoadValorantcleaner();
        }
        private void CleanFortniteButton_Click(object sender, EventArgs e)
        {
            Download.Loadfortnitecleaner();
        }
        private void CleanBEButton_Click(object sender, EventArgs e)
        {
            Download.LoadBEcleaner();
        }

        private void CleanMWButton_Click(object sender, EventArgs e)
        {
            Download.LoadMWcleaner();
        }

        private void CleanapexButton_Click_1(object sender, EventArgs e)
        {

        }

        private void CleanerForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
