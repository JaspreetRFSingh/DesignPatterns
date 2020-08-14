using DesignPatterns.Factory.Model;

namespace DesignPatterns.FactoryMethod
{
    public class OrderManagerFactory
    {
        public BaseOrderTypeFactory CreateFactory(Order order)
        {
            BaseOrderTypeFactory factory = null;
            if(order.OrderTypeId == 1)
            {
                factory = new StandardOrderFactory(order);
            }
            else if (order.OrderTypeId == 2)
            {
                factory = new ConventionOrderFactory(order);
            }
            else if (order.OrderTypeId == 3)
            {
                factory = new BulkOrderFactory(order);
            }
            return factory;
        }
    }
}
