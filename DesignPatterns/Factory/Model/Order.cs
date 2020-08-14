using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderTypeId { get; set; }
        public int MinDeliveryDays { get; set; }
        public decimal MaxDiscountApplicable { get; set; }
        public string DeliveryType { get; set; }
    }
}
