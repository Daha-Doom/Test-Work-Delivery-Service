using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТестовоеЗаданиеСлужбаДоставки.Model
{
    internal class Loger
    {
        public Loger(string massage)
        {
            using (StreamWriter sw = new StreamWriter(".//Data//Log.txt", true))
            {
                string line = massage + "\t" + DateTime.Now;

                sw.WriteLine(line);
            }
        }
    }
}
