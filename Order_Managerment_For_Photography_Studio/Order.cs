using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Order_Managerment_For_Photography_Studio
{
    public class Order
    {
        public String CustomerName { get; set; }
        public String OrderDate { get; set; }
        public Boolean Payment { get; set; }
        public int TotalFee { get; set; }
        public int OrderCode { get; set; }
        public String Note { get; set; }
        public String PathOfImage { get; set; }

        public Order()
        {

        }
        public Order(String customerName, String orderDate, int totalFee, Boolean payment, int orderCode, String note, String pathOfImage)
        {
            this.CustomerName = customerName;
            this.OrderDate = orderDate;
            this.Payment = payment;
            this.TotalFee = totalFee;
            this.OrderCode = orderCode;
            this.Note = note;
            this.PathOfImage = pathOfImage;
        }

        public override string ToString()
        {
            return "" + this.CustomerName + "|" + this.OrderDate + "|" + this.TotalFee + "|" + this.Payment + "|" + this.OrderCode + "|" + this.Note + '|' + this.PathOfImage;
        }
    }
}