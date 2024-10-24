using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТестовоеЗаданиеСлужбаДоставки
{
    public class Orders
    {
        public int idOrder { get; set; }
        private float orderWeight;
        public float OrdersWeight
        {
            get { return orderWeight; }
            set { orderWeight = value; }
        }
        private int orderDistrictID { get; set; }
        public int OrdersDistrictID
        {
            get { return orderDistrictID; }
            set { orderDistrictID = value; }
        }
        private string orderDeliveryDateTime {  get; set; }
        public string OrdersDeliveryDateTime
        {
            get { return orderDeliveryDateTime; }
            set { orderDeliveryDateTime = value; }
        }

        public Orders() { }

        public Orders(int idOrder, float orderWeight, int orderDistrictID, string orderDeliveryDateTime)
        {
            this.idOrder = idOrder;
            this.orderWeight = orderWeight;
            this.orderDistrictID = orderDistrictID;
            this.orderDeliveryDateTime = orderDeliveryDateTime;
        }
    }
}
