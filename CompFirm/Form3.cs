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
    public partial class frmLaptop : Form
    {
        public frmLaptop()
        {
            InitializeComponent();
        }

        private void laptopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laptopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st03DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st03DataSet.Laptop". При необходимости она может быть перемещена или удалена.
            this.laptopTableAdapter.Fill(this.st03DataSet.Laptop);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.laptopBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.laptopBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.laptopBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.laptopBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.laptopBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.laptopBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laptopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st03DataSet);
        }
    }
}
