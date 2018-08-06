using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment_19_07_2018_01
{
    class PizzaOrder
    {
        public int order_id { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public DateTime order_date { get; set; }
        public char pizza_size { get; set; }
        public string pizza_type { get; set; }
        public string toppings { get; set; }
    }
}
