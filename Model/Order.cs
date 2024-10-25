using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ТестовоеЗаданиеСлужбаДоставки.Data;

namespace ТестовоеЗаданиеСлужбаДоставки
{
    internal class Order
    {
        public int idOrder {  get; set; }
        public float orderWeight { get; set; }
        public string orderDistrictName { get; set; }
        public DateTime orderDeliveryDateTime { get; set; }

        public Order() { }

        public Order (int idOrder, float orderWeight, string orderDistrictName, string orderDeliveryDateTime)
        {
            this.idOrder = idOrder;
            this.orderWeight = orderWeight;
            this.orderDistrictName = orderDistrictName;
            this.orderDeliveryDateTime = DateTime.Parse(orderDeliveryDateTime);
        }

        public Order(float orderWeight, string orderDistrictName, DateTime orderDeliveryDateTime)
        {
            this.orderWeight = orderWeight;
            this.orderDistrictName = orderDistrictName;
            this.orderDeliveryDateTime = orderDeliveryDateTime;
        }

        public override string ToString()
        {
            return this.idOrder + " \t" + this.orderWeight + " \t" + this.orderDistrictName + " \t" + orderDeliveryDateTime;
        }

        //Фильтрация по району
        public List<Order> FilterByDistrict (List<Order> orders, string filterOption)
        {
            orders = orders.Where(order => order.orderDistrictName == filterOption).ToList();

            return orders;
        }


        //Фильтрация по дате
        public List<Order> FilterByDate (List<Order> orders, DateTime dateTimeBefore, DateTime dateTimeAfter)
        {
            orders = orders.Where(order => order.orderDeliveryDateTime > dateTimeBefore && order.orderDeliveryDateTime < dateTimeAfter).ToList();

            return orders;
        }

        public void Sort (List<Order> orders, int typeOptions)
        {
            switch (typeOptions)
            {
                //Сортировка по ID
                case 0:
                    orders.Sort(new OrderIDComparerAscending());
                    break;
                //Сортировка по весу по возрастанию
                case 1:
                    orders.Sort(new OrderWeightComparerAscending());
                    break;
                //Сортировка по району по возрвстанию
                case 2:
                    orders.Sort(new OrderDistrictComparerAscending());
                    break;
                //Сортировка по дате по возрастанию
                case 3:
                    orders.Sort(new OrderDateComparerAscending());
                    break;
                //Сортировка по весу по убыванию
                case 4:
                    orders.Sort(new OrderWeightComparerDescending());
                    break;
                //Сортировка по району по убыванию
                case 5:
                    orders.Sort(new OrderDistrictComparerDescending());
                    break;
                //Сортировка по дате по убыванию
                case 6:
                    orders.Sort(new OrderDateComparerDescending());
                    break;
            }
        }

        public class OrderIDComparerAscending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return x.idOrder.CompareTo(y.idOrder);
            }
        }

        public class OrderWeightComparerAscending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return x.orderWeight.CompareTo(y.orderWeight);
            }
        }

        public class OrderDistrictComparerAscending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return string.Compare(x.orderDistrictName, y.orderDistrictName);
            }
        }

        public class OrderDateComparerAscending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return x.orderDeliveryDateTime.CompareTo(y.orderDeliveryDateTime);
            }
        }

        public class OrderWeightComparerDescending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return -x.orderWeight.CompareTo(y.orderWeight);
            }
        }

        public class OrderDistrictComparerDescending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return -string.Compare(x.orderDistrictName, y.orderDistrictName);
            }
        }

        public class OrderDateComparerDescending : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                return -x.orderDeliveryDateTime.CompareTo(y.orderDeliveryDateTime);
            }
        }
    }
}
