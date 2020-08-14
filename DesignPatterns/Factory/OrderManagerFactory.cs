using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class OrderManagerFactory
    {
        public IOrderTypeManager GetOrderTypeManager(int orderTypeId)
        {
            IOrderTypeManager orderType = null;
            if(orderTypeId == 1)
            {
                orderType = new StandardOrderManager();
            }
            else if (orderTypeId == 2)
            {
                orderType = new ConventionOrderManager();
            }
            else if (orderTypeId == 3)
            {
                orderType = new BulkOrderManager();
            }
            return orderType;
        }
    }
}
