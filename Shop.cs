using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Shop
    {
        List<Order> orders = new List<Order>();
        public void AddOrder(Order ord)
        {
            orders.Add(ord);
        }
        public int GetOrdersAvg()
        {
            int sum = 0;
            foreach (var item in orders)
            {
                sum += item.TotalAmount;
            }
            sum /= orders.Count;
            return sum;
        }
        public void RemoveOrderByNo(int no)
        {
            orders.Remove(orders.Find(o => o.No == no));

        }
        public int GetOrdersAvg(DateTime date)
        {
            List<Order> filterbyprice = new List<Order>();

            filterbyprice.AddRange(orders.FindAll(o => o.CreatedAt.Date >= date));
            int sum = 0;
            foreach (var item in filterbyprice)
            {
                sum += item.TotalAmount;
            }
            sum = sum/ filterbyprice.Count;   
            return sum;

        }
        public List<Order> FilterOrderByPrice(int min, int max)
        {
            List<Order> filterbyprice = new List<Order>();
            var result = orders.Find(o => o.TotalAmount >= min && o.TotalAmount <= max);
            filterbyprice.Add(result);
            return filterbyprice;
        }
    }
}
