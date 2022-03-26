using System;
using System.Windows.Forms;

namespace Workings
{
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void catalogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.catalogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_shopDataSet);

        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.computer_shopDataSet.Catalogs);

        }
    }
}
