using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public interface IOrderTypeManager
    {
        string GetDeliveryType();
    }
}
