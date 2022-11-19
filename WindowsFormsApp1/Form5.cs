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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void отгрузкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отгрузкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fabricDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.Отгрузка". При необходимости она может быть перемещена или удалена.
            this.отгрузкаTableAdapter.Fill(this.fabricDataSet.Отгрузка);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }

        private void состаОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.Show();
            this.Hide();
        }

        private void отгрузкаBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            отгрузкаBindingSource.Filter = "IdОтгрузки=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            отгрузкаBindingSource.Filter = null;
        }
    }
}
