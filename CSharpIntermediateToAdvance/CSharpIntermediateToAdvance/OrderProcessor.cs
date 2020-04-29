using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateToAdvance
{
    class OrderProcessor
    {
        private ShippingCalculorcs shippingCalculorcs;

        public OrderProcessor(ShippingCalculorcs shippingCalculorcs)
        {
            this.shippingCalculorcs = shippingCalculorcs;
        }

        internal void Process(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
