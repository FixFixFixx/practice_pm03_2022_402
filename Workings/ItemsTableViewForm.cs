using System;
using System.Drawing;
using System.Windows.Forms;

namespace Workings
{
    public partial class ItemsTableViewForm : Form
    {
        private System.Windows.Forms.DataGridViewColumn collumnName;

        public ItemsTableViewForm()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.computer_shopDataSet);
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, несколько записей одновременно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ItemsTableViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.computer_shopDataSet.Items);

        }

        private void sortlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortBtn.Enabled = true;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            //создание переменной для хранения имени выбранного столбца
            this.collumnName = new System.Windows.Forms.DataGridViewColumn();

            switch (sortlistBox.SelectedIndex)
            {
                case 0:
                    collumnName = nameDataGridViewTextBoxColumn;
                    break;
                case 1:
                    collumnName = priceDataGridViewTextBoxColumn;
                    break;
                case 2:
                    collumnName = countDataGridViewTextBoxColumn;
                    break;
                case 3:
                    collumnName = markDataGridViewTextBoxColumn;
                    break;
                case 4:
                    collumnName = descDataGridViewTextBoxColumn;
                    break;
                case 5:
                    collumnName = productGroupDataGridViewTextBoxColumn;
                    break;
            }

            if (sortUpRadioBtn.Checked)
            {
                itemsDataGridView.Sort(collumnName, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                itemsDataGridView.Sort(collumnName, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            itemsBindingSource.Filter = $"NAME='{nameComboBox.Text}'";
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            itemsBindingSource.Filter = "";
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemsBindingSource.Count - 1; i++)
            {
                for (int j = 0; j < itemsBindingSource.Count - 1; j++)
                {
                    itemsDataGridView[i, j].Style.BackColor = Color.White;
                    itemsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < itemsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < itemsDataGridView.RowCount - 1; j++)
                {
                    if (itemsDataGridView[i, j].Value.ToString().IndexOf(criteriaTextBox.Text) != -1)
                    {
                        itemsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        itemsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
