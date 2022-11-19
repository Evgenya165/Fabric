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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сырьёBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сырьёBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fabricDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDataSet.Сырьё". При необходимости она может быть перемещена или удалена.
            this.сырьёTableAdapter.Fill(this.fabricDataSet.Сырьё);

        }

        private void пставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void отгрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.Show();
            this.Hide();
        }

        private void складыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
            this.Hide();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            сырьёBindingSource.Filter = "IdСырья=\'" + toolStripTextBox1.Text + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            сырьёBindingSource.Filter = null;
        }
    }
}
