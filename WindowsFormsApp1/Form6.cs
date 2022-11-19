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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void состав_отгрузкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.состав_отгрузкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fabricDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.Состав_отгрузки". При необходимости она может быть перемещена или удалена.
            this.состав_отгрузкиTableAdapter.Fill(this.fabricDataSet.Состав_отгрузки);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            состав_отгрузкиBindingSource.Filter = "IdПоставки=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            состав_отгрузкиBindingSource.Filter = null;
        }
    }
}
