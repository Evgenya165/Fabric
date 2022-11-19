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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void состав_поставкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.состав_поставкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fabricDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.Состав_поставки". При необходимости она может быть перемещена или удалена.
            this.состав_поставкиTableAdapter.Fill(this.fabricDataSet.Состав_поставки);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            состав_поставкиBindingSource.Filter = "IdПоставки=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            состав_поставкиBindingSource.Filter = null;
        }

        private void состав_поставкиBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
