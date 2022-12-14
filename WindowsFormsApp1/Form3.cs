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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fabricDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.fabricDataSet.Поставщик);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.Filter = "IdПоставщика=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.Filter = null;

        }
    }
}
