using DesignPatterns.Factory;
using DesignPatterns.Factory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class ConventionOrderFactory : BaseOrderTypeFactory
    {
        public ConventionOrderFactory(Order order) : base(order)
        {
        }

        public override IOrderTypeManager Create()
        {
            ConventionOrderManager manager = new ConventionOrderManager();
            _order.MinDeliveryDays = manager.MinDaysRequired();
            return manager;
        }
    }
}
