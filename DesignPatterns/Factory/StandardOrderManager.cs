using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class StandardOrderManager : IOrderTypeManager
    {
        public string GetDeliveryType()
        {
            return "Quick-Standard";
        }

        public int MinDaysRequired()
        {
            return 1;
        }
    }
}
