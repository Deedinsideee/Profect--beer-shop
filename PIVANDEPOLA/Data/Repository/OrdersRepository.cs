using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.intefaces;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent,ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;

        }
        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = shopCart.listShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OderDetails()
                {
                    PiboID = el.pivo.id,
                    orderID = order.id,
                    price = el.pivo.price



                };
                appDBContent.OrderDetails.Add(orderDetail);

            }
            appDBContent.SaveChanges();
        }
    }
}
