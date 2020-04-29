//using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

using System;

namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {
            /* 
             * ///Section 6
                Interfaces
                Lecture 33
               Interface and Testibility
*/
            //creating a new orderprocessor object
            var orderProcessor = new OrderProcessor(new ShippingCalculorcs());

            //creating a new order
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }


        public class Shipment
        {
            public float Cost { get; set; }
            public DateTime ShippingDate { get; set; }
        }
    }
        //..........................................................................

//        using CSharpIntermediateToAdvance;

//namespace CSharpIntermediate
  //  {
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
    //}



    //..........................................................................
    /*using System;
using System.Collections.Generic;
using System.Text;
*/

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



}



