using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ТестовоеЗаданиеСлужбаДоставки.Data;
using ТестовоеЗаданиеСлужбаДоставки.Model;
using ТестовоеЗаданиеСлужбаДоставки.Transfer;
using ТестовоеЗаданиеСлужбаДоставки.View;

namespace ТестовоеЗаданиеСлужбаДоставки
{
    public partial class MainForm : Form
    {
        DataBaseConnection connection = new DataBaseConnection();

        List<Order> orders = new List<Order>();
        List<Order> ordersChanged = new List<Order>();
        List<Order> ordersSorted = new List<Order>();
        Order order = new Order();

        Loger loger;

        public MainForm()
        {
            InitializeComponent();

            loger = new Loger("Запуск приложение");
        }

        //Учитывание даты при фильтрации
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

        //Загрузка основной формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.ReadData(orders, "vOrders");
            }
            catch (Exception ex)
            {
                btnFilter.Enabled = false;
                btnSort.Enabled = false;
                tsmiNewOrder.Enabled = false;
                tsmiSaveTXT.Enabled = false;
                tsmiSaveXLSX.Enabled = false;

                MessageBox.Show("Ошибка загрузки базы данных" + ex.Message);
            }

            Districts districts = new Districts();

            for (int i = 0; i < Districts.districtsName.Count; i++)
                combDistrictFilter.Items.Add(Districts.districtsName[i]);

            for (int i = 0; i < orders.Count; i++)
                ordersChanged.Add(orders[i]);

            FillDataGreedView(orders);
        }

        //Запуск окна добавления нового заказа
        private void tsmiNewOrder_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();

            orders = new List<Order>();
            connection.ReadData(orders, "vOrders");

            FillDataGreedView(orders);
        }

        //Запуск окна информации о приложении
        private void tsmiInfo_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        //Заполнение таблицы
        private void FillDataGreedView(List<Order> orders)
        {
            dgvOrders.DataSource = orders;

            dgvOrders.ColumnHeadersVisible = true;

            dgvOrders.DefaultCellStyle.Font = new Font("v_Blambot Casual", 12);

            dgvOrders.Columns[2].Width = 150;

            dgvOrders.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
            dgvOrders.Columns[3].Width = 200;

            dgvOrders.Columns[0].HeaderText = "ID";
            dgvOrders.Columns[1].HeaderText = "Вес";
            dgvOrders.Columns[2].HeaderText = "Район";
            dgvOrders.Columns[3].HeaderText = "Дата";

            dgvOrders.Refresh();
        }

        //Кнопка фильтрации
        private void btnFilter_Click(object sender, EventArgs e)
        {
            ordersChanged = new List<Order>();
            for (int i = 0; i < orders.Count; i++)
                ordersChanged.Add(orders[i]);

            SortingOrders();

            FilterOrders();

            FillDataGreedView(ordersChanged);
        }

        //Кнопка сортировки
        private void btnSort_Click(object sender, EventArgs e)
        {
            loger = new Loger("Выполнена сортировка " + combSortOptions.Text.ToLower() + 
                " и фильтрация (" + combDistrictFilter.Text + "; " + dtpBefor.Value.ToShortDateString() + " - " + dtpAfter.Value.ToShortDateString() + ")");

            ordersChanged = new List<Order>();
            for (int i = 0; i < orders.Count; i++)
                ordersChanged.Add(orders[i]);

            FilterOrders();

            SortingOrders();

            FillDataGreedView(ordersChanged);
        }

        // Фильтрация
        private void FilterOrders()
        {
            loger = new Loger("Выполнена фильтрация (" + combDistrictFilter.Text + "; " + dtpBefor.Value.ToShortDateString() + " - " + dtpAfter.Value.ToShortDateString() + ")" + 
                " и сортировка " + combSortOptions.Text.ToLower());

            if (combDistrictFilter.Text != "Не имеет значения")
                ordersChanged = order.FilterByDistrict(ordersChanged, combDistrictFilter.Text);

            if (!chbConsiderDate.Checked)
            {
                DateTime dateTimeBefor = dtpBefor.Value;
                DateTime dateTimeAfter = dtpAfter.Value;

                ordersChanged = order.FilterByDate(ordersChanged, dateTimeBefor, dateTimeAfter);
            }
        }

        //Сортировка
        private void SortingOrders()
        {
            if (rbAscending.Checked)
            {
                if (combSortOptions.Text == "Нет")
                    order.Sort(ordersChanged, 0);
                else if (combSortOptions.Text == "По весу")
                    order.Sort(ordersChanged, 1);
                else if (combSortOptions.Text == "По району")
                    order.Sort(ordersChanged, 2);
                else if (combSortOptions.Text == "По дате")
                    order.Sort(ordersChanged, 3);
            }
            else
            {
                if (combSortOptions.Text == "Нет")
                    order.Sort(ordersChanged, 0);
                else if (combSortOptions.Text == "По весу")
                    order.Sort(ordersChanged, 4);
                else if (combSortOptions.Text == "По району")
                    order.Sort(ordersChanged, 5);
                else if (combSortOptions.Text == "По дате")
                    order.Sort(ordersChanged, 6);
            }
        }

        //Кнопка сохранения в текстовый файл
        private void tsmiSaveTXT_Click(object sender, EventArgs e)
        {
            try
            {
                SaveToTextFile saveToTextFile = new SaveToTextFile(dgvOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Кнопка сохранения в Exel файл
        private void tsmiSaveXLSX_Click(object sender, EventArgs e)
        {
            try
            {
                SaveToExelFile saveToExelFile = new SaveToExelFile(dgvOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
