using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ТестовоеЗаданиеСлужбаДоставки.Data;

namespace ТестовоеЗаданиеСлужбаДоставки.Model
{
    internal class DataBaseConnection
    {
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConnection;

            sqliteConnection = new SQLiteConnection("Data Source = .//Data//Orders.db; Version = 3; New = True; Compress = True; ");

            try
            {
                sqliteConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sqliteConnection;
        }

        public void ReadData(List<Order> orders, string tableName)
        {
            SQLiteDataReader reader;
            SQLiteCommand sqliteCommand;

            SQLiteConnection sqliteConnection = CreateConnection();

            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM " + tableName;

            reader = sqliteCommand.ExecuteReader();

            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                        orders.Add(new Order(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetString(3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqliteConnection.Close();
        }

        public void ReadDistrictName(List<string> districts)
        {
            SQLiteDataReader reader;
            SQLiteCommand sqliteCommand;

            SQLiteConnection sqliteConnection = CreateConnection();

            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM Districts";

            reader = sqliteCommand.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                        districts.Add(reader.GetString(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqliteConnection.Close();
        }

        public void WriteData(Order order)
        {
            SQLiteCommand sqliteCommand;
            SQLiteConnection sqliteConnection = CreateConnection();

            int i = 0;
            for (i = 0; i < Districts.districtsName.Count; i++)
                if (order.orderDistrictName == Districts.districtsName[i])
                    break;

            string stringDateTime = order.orderDeliveryDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string stringWaight = order.orderWeight.ToString("F2", CultureInfo.InvariantCulture);

            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = $"INSERT INTO Orders (orderWeight, orderDistrictID, orderDeliveryDateTime) VALUES (@value, {i + 1}, '{stringDateTime}');";

            sqliteCommand.Parameters.AddWithValue("@value", stringWaight);

            try
            {
                sqliteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqliteConnection.Close();
        }
    }
}
