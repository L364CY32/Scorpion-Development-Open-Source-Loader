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
    public partial class Cheats : Form
    {
        public Cheats()
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
        private void CheatForm_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastpoint = new Point(e.X, e.Y);
            }


        }

        private void CheatForm_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastpoint.X;
                    this.Top += e.Y - lastpoint.Y;
                }
            }
        }

        private void Loadapexscript_Click(object sender, EventArgs e)
        {
            Download.Loadapexscript();

        }

       

     
      

        private void Loadcsgo_Click_1(object sender, EventArgs e)
        {

        }

        private void Loadapexscript_Click_1(object sender, EventArgs e)
        {
            Download.Loadapexscript();
        }

        private void CheatForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

