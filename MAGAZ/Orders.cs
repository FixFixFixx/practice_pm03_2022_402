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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bAZADataSet.ViewORDER". При необходимости она может быть перемещена или удалена.
            this.viewORDERTableAdapter.Fill(this.bAZADataSet.ViewORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bAZADataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.bAZADataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox11.Text = Convert.ToString(Convert.ToDouble(pricetextBox.Text) *
            Convert.ToDouble(numbertextBox.Text));

        }
    }
}
