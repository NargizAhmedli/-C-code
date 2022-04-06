using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Order
    {
        private static int _no;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }

        private static DateTime _createdAt;
        public DateTime CreatedAt { get; set; }
        public Order()
        {
            _createdAt = DateTime.UtcNow.Date;
            CreatedAt = _createdAt;
            _no++;
            No = _no;
        }
    }
}
