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
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bAZADataSet.Catalog". При необходимости она может быть перемещена или удалена.
            this.catalogTableAdapter.Fill(this.bAZADataSet.Catalog);

        }
    }
}
