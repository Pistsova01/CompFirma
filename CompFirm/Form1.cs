using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompFirm
{
    public partial class Form1 : Form
    {
        private frmDesktop frmDesktop;
        private frmLaptop frmLaptop;
        private frmPrinter frmPrinter;
        private frmProizvod frmProizvod;
        private table table;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDesktop = new frmDesktop();
            this.Hide();
            frmDesktop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLaptop = new frmLaptop();
            this.Hide();
            frmLaptop.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrinter = new frmPrinter();
            this.Hide();
            frmPrinter.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProizvod = new frmProizvod();
            this.Hide();
            table = new table();
            table.Visible = true;
        }
    }
}
