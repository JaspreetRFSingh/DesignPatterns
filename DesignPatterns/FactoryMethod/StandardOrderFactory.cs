using DesignPatterns.Factory;
using DesignPatterns.Factory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class StandardOrderFactory : BaseOrderTypeFactory
    {
        public StandardOrderFactory(Order order) : base(order)
        {
        }

        public override IOrderTypeManager Create()
        {
            StandardOrderManager manager = new StandardOrderManager();
            _order.MinDeliveryDays = manager.MinDaysRequired();
            return manager;
        }
    }
}
