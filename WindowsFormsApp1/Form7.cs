using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void складыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fabricDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter.Fill(this.fabricDataSet.Склады);

        }

        private void складыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 s = new Form8();
            s.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            складыBindingSource.Filter = "IdСклада=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            складыBindingSource.Filter = null;
        }
    }
}
