using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ТестовоеЗаданиеСлужбаДоставки.Model;

namespace ТестовоеЗаданиеСлужбаДоставки.Data
{
    internal class Districts
    {
        public static List<string> districtsName;

        public Districts()
        {
            districtsName = new List<string>();
            
            DataBaseConnection db = new DataBaseConnection();

            db.ReadDistrictName(districtsName);
        }
    }
}
