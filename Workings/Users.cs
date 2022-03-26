using System;
using System.Windows.Forms;

namespace Workings
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_shopDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.computer_shopDataSet.Users);

        }
    }
}
