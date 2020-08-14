using DesignPatterns.Factory;
using DesignPatterns.Factory.Model;

namespace DesignPatterns.FactoryMethod
{
    /*
        Order order = //order object coming from a source
        BaseOrderTypeFactory orderTypeFactory = new OrderManagerFactory().CreateFactory(order);
        orderTypeFactory.ApplyDeliveryMethod();
    */


    public abstract class BaseOrderTypeFactory
    {
        protected Order _order;
        public BaseOrderTypeFactory(Order order) {
            _order = order;
        }
        public abstract IOrderTypeManager Create();
        public Order ApplyDeliveryMethod()
        {
            IOrderTypeManager manager = this.Create();
            _order.DeliveryType = manager.GetDeliveryType();
            return _order;
        }
    }
}
