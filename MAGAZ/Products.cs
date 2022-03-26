using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGAZ
{
    public partial class Products : Form
    {
        private FormTableProducts productstable;

        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bAZADataSet1.Catalog". При необходимости она может быть перемещена или удалена.
            this.catalogTableAdapter.Fill(this.bAZADataSet1.Catalog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bAZADataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.bAZADataSet.Products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bAZADataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            productstable = new FormTableProducts();
            productstable.Visible = true;
        }
    }
}
