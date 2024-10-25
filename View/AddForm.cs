using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ТестовоеЗаданиеСлужбаДоставки.Data;
using ТестовоеЗаданиеСлужбаДоставки.Model;

namespace ТестовоеЗаданиеСлужбаДоставки.View
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (tbWeight.Text == "")
                MessageBox.Show("Введите вес товара");
            else
            {
                Order order = new Order(float.Parse(tbWeight.Text), combDistrictName.Text, dtpDateOrder.Value);

                DataBaseConnection conn = new DataBaseConnection();
                conn.WriteData(order);

                Loger loger = new Loger("Добавлена новы запись: " + order.ToString());

                this.Close();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Districts.districtsName.Count; i++)
                combDistrictName.Items.Add(Districts.districtsName[i]);

            combDistrictName.Text = combDistrictName.Items[0].ToString();
        }

        private void tbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
