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
    public partial class frmPrinter : Form
    {
        public frmPrinter()
        {
            InitializeComponent();
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st03DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st03DataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.st03DataSet.Printer);

        }
    }
}
