using System;
using System.Windows.Forms;

namespace Workings
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_shopDataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.ViewOrders". При необходимости она может быть перемещена или удалена.
            this.viewOrdersTableAdapter.Fill(this.computer_shopDataSet.ViewOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.computer_shopDataSet.Orders);

        }
    }
}
