using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ТестовоеЗаданиеСлужбаДоставки
{
    public partial class MainForm : Form
    {
        ApplicationContext db;
        List<Orders> orders;

        public MainForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
            orders = db.Orders.ToList();
        }

        private void chbConsiderDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbConsiderDate.Checked == true)
            {
                dtpAfter.Enabled = false;
                dtpBefor.Enabled = false;
            }
            else
            {
                dtpAfter.Enabled = true;
                dtpBefor.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvOrders.DataSource = orders;
        }
    }
}
