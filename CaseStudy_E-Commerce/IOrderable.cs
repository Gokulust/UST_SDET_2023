using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_E_Commerce
{
    internal interface IOrderable
    {
        void PlacingOrders();
        void ProcessingPayment();
        void DeliveringProduct();
        
    }
}
