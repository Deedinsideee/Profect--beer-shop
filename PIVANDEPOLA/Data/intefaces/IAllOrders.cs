using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.intefaces
{
   public  interface IAllOrders
    {
        void createOrder(Order order);
    }
}
