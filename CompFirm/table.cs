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
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        private void laptopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laptopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st03DataSet);

        }

        private void table_Load(object sender, EventArgs e)
        {
            this.makerProdTableAdapter.Fill(this.st03DataSet.makerProd);
            this.productTableAdapter.Fill(this.st03DataSet.Product);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private System.Windows.Forms.DataGridViewColumn COL;
        private void button1_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;

                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn4;

                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;

                    break;
            }
            if (radioButton1.Checked)
                makerProdDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                makerProdDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "maker='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    makerProdDataGridView[i, j].Style.BackColor = Color.White;
                    makerProdDataGridView[i, j].Style.ForeColor = Color.Black;

                }
            }
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    if (makerProdDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        makerProdDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        makerProdDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                        

        