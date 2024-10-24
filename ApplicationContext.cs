using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ТестовоеЗаданиеСлужбаДоставки
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Orders> Orders { get; set; }

        public ApplicationContext() : base("Default") { }
    }
}
