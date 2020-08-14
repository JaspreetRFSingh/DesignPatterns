using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ConventionOrderManager : IOrderTypeManager
    {
        public string GetDeliveryType()
        {
            return "Convention Quick 1Day";
        }
    }
}
