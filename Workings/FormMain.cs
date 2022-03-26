using System;
using System.Windows.Forms;

namespace Workings
{
    public partial class FormMain : Form
    {
        private Users users;
        private Catalogs catalogs;
        private Orders orders;
        private Items items;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            users = new Users();
            users.Visible = true;
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            catalogs = new Catalogs();
            catalogs.Visible = true;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            orders = new Orders();
            orders.Visible = true;
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            items = new Items();
            items.Visible = true;
        }
    }
}
