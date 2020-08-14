
namespace DesignPatterns.Factory
{
    public class BulkOrderManager : IOrderTypeManager
    {
        public string GetDeliveryType()
        {
            return "Bulk 1-Week";
        }
    }
}
