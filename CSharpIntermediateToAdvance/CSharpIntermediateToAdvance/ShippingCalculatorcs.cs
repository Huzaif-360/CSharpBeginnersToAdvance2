using CSharpIntermediateToAdvance;

namespace CSharpIntermediate
{
    public interface IShippingCalculatcr
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculatcr
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            return 0;
        }
    }
}
