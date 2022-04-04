using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Managerment_For_Photography_Studio
{
    public class mainProcess
    {
        public static void getDataFromFile(List<Order> orderList, ExternalFile file)
        {
            if (file.isEmpty()) return;

            List<String> stringList = file.readAllTextFromFile();
            foreach(String str in stringList)
            {
                Order newOrder = new Order();
                String[] arrString = str.Split('|');
                newOrder.CustomerName = arrString[0];
                newOrder.OrderDate = arrString[1];
                newOrder.TotalFee = Convert.ToInt32(arrString[2]);
                newOrder.Payment = Convert.ToBoolean(arrString[3]);
                newOrder.OrderCode = Convert.ToInt32(arrString[4]);
                newOrder.Note = arrString[5];
                newOrder.PathOfImage = arrString[6];


                orderList.Add(newOrder);
            }
        }

        public static void addNewOrderToList(List<Order> orderList, Order newOrder)
        {
            orderList.Add(newOrder);
        }


        public static List<Order> findOrderbyName(List<Order> orderList, String name)
        {
            List<Order> resultList = new List<Order>();

            foreach(Order order in orderList)
            {
                if (order.CustomerName.Contains(name))
                    resultList.Add(order);
            }

            return resultList;
        }

        public static List<Order> findOrder(List<Order> orderList, String name, String date)
        {
            List<Order> resultList = new List<Order>();

            foreach (Order order in orderList)
            {
                if (order.CustomerName.Contains(name) && order.OrderDate.CompareTo(date) == 0)
                    resultList.Add(order);
            }

            return resultList;
        }
        public static List<Order> findOrderByDate(List<Order> orderList, String date)
        {
            List<Order> resultList = new List<Order>();

            foreach (Order order in orderList)
            {
                if (order.OrderDate.CompareTo(date) == 0)
                    resultList.Add(order);
            }

            return resultList;
        }
    }
}
