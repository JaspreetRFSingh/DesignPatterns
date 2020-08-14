using DesignPatterns.Factory;
using DesignPatterns.Factory.Model;

namespace DesignPatterns.FactoryMethod
{
    public class BulkOrderFactory : BaseOrderTypeFactory
    {
        public BulkOrderFactory(Order order) : base(order)
        {
        }

        public override IOrderTypeManager Create()
        {
            BulkOrderManager manager = new BulkOrderManager();
            _order.MaxDiscountApplicable = manager.MaxDiscountApplicable();
            return manager;
        }
    }
}
