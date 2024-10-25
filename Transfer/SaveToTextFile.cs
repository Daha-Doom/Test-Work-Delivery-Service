using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ТестовоеЗаданиеСлужбаДоставки.Model;

namespace ТестовоеЗаданиеСлужбаДоставки.Transfer
{
    internal class SaveToTextFile
    {
        public SaveToTextFile(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    string line = "";
                    
                    //Запись заголовков столбцов
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                        line += dataGridView.Columns[i].HeaderText;

                    sw.WriteLine(line);

                    //Запись данных
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        line = "";

                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                            line += dataGridView.Rows[i].Cells[j].Value.ToString() + "\t";

                        sw.WriteLine(line);
                    }
                }

                Loger loger = new Loger("Выполнено сохранение таблицы в файл " + saveFileDialog.FileName);
            }
        }
    }
}