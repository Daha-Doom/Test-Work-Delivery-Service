using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using ТестовоеЗаданиеСлужбаДоставки.Model;

namespace ТестовоеЗаданиеСлужбаДоставки.Transfer
{
    internal class SaveToExelFile
    {
        public SaveToExelFile(DataGridView dataGridView) 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel файлы (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Книга1");

                    // Запись заголовков столбцов
                    for (int i = 1; i <= dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                    }

                    // Запись данных
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.GetType() == typeof(DateTime) ? dataGridView.Rows[i].Cells[j].Value.ToString() : dataGridView.Rows[i].Cells[j].Value;

                        }
                    }

                    package.SaveAs(new FileInfo(saveFileDialog.FileName));

                    Loger loger = new Loger("Выполнено сохранение таблицы в файл " + saveFileDialog.FileName);
                }
            }
        }
    }
}
