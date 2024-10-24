using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТестовоеЗаданиеСлужбаДоставки
{
    internal class Order
    {
        public int idOrder {  get; set; }
        public float orderWeight { get; set; }
        public string orderDistrictName { get; set; }
        public DateTime orderDeliveryDateTime {  get; set; }

        public Order() { }

        public Order (int idOrder, float orderWeight, string orderDistrictName, string orderDeliveryDateTime)
        {
            this.idOrder = idOrder;
            this.orderWeight = orderWeight;
            this.orderDistrictName = orderDistrictName;
            this.orderDeliveryDateTime = DateTime.Parse(orderDeliveryDateTime);
        }
    }
}
