using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Form1 : Form
    {
        private Users users;
        private Products products;
        private Catalogs catalogs;
        private Orders orders;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orders = new Orders();
            orders.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            users = new Users();
            users.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            products = new Products();
            products.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catalogs = new Catalogs();
            catalogs.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
