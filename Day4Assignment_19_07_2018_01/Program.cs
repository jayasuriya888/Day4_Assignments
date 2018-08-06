using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment_19_07_2018_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> list = new List<PizzaOrder> {
                new PizzaOrder { order_id =1001, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'S', toppings ="Sweet Corn", qty = 5 , price = 5000 },
                new PizzaOrder { order_id =1002, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'M', toppings ="Chicken", qty = 9 , price = 9600 },
                new PizzaOrder { order_id =1009, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'L', toppings ="Egg", qty = 6 , price = 5800 },
                new PizzaOrder { order_id =1003, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'M', toppings ="Onion", qty = 3 , price = 950 },
                new PizzaOrder { order_id =1007, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'L', toppings ="Capsicum", qty = 2 , price = 500 },
                new PizzaOrder { order_id =1006, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'L', toppings ="Chicken", qty = 5 , price = 2500 },
                new PizzaOrder { order_id =1008, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'M', toppings ="Tomato", qty = 8 , price = 7500 },
                new PizzaOrder { order_id =1005, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'S', toppings ="Egg", qty = 4 , price = 1900 }

            };

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display all pizza ordered");
            Console.WriteLine();
            
            var data1 = from t in list select t;
            foreach (var d in data1)
                Console.WriteLine(d.order_id+"  ,  "+d.order_date + "  ,  " +d.pizza_type + "  ,  " +d.pizza_size + "  ,  " +d.toppings + "  ,  " +d.qty + "  ,  " +d.price);

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display Pizza based on PizzaType == 'Non Veg' and PizzaSize=='S'");
            Console.WriteLine();

            var data2 = from t in list where t.pizza_type=="Non Veg" && t.pizza_size=='S' select t;
             foreach (var d in data2)
                Console.WriteLine(d.order_id + "  ,  " + d.order_date + "  ,  " + d.pizza_type + "  ,  " + d.pizza_size + "  ,  " + d.toppings + "  ,  " + d.qty + "  ,  " + d.price);

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display Count of Pizza Sold, Amount Collected group by PizzaType");
            Console.WriteLine("");

            var data3 = from t in list group t by t.pizza_type into grp select new {Pizza_Type = grp.Key , Count = grp.Count() , Amount_Collected = grp.Sum(x=>x.price) };
            foreach (var d in data3)
                Console.WriteLine(d);

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display Count of Pizza Sold , Amount Collected group by Pizza Size");
            Console.WriteLine("");

            var data4 = from t in list group t by t.pizza_size into grp select new { Pizza_Size = grp.Key, Count = grp.Count(), Amount_Collected = grp.Sum(x => x.price) };
            foreach (var d in data4)
                Console.WriteLine(d);

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display only PizzaType and Toppings where PizzaSize=’M’");
            Console.WriteLine("");

            var data5 = from t in list where t.pizza_size == 'M' select new { Pizza_Type = t.pizza_type , Toppings = t.toppings};
            foreach (var d in data5)
                Console.WriteLine(d);

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display the Pizza Details which has the Max Price");
            Console.WriteLine("");

            var data6 = from t in list where t.price == list.Max(x=>x.price) select t;
            foreach (var d in data6)
                Console.WriteLine(d.order_id + "  ,  " + d.order_date + "  ,  " + d.pizza_type + "  ,  " + d.pizza_size + "  ,  " + d.toppings + "  ,  " + d.qty + "  ,  " + d.price);

            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("Display the Pizza Details which has the Min Price");
            Console.WriteLine("");

            var data7 = from t in list where t.price == list.Min(x => x.price) select t;
            foreach (var d in data7)
                Console.WriteLine(d.order_id + "  ,  " + d.order_date + "  ,  " + d.pizza_type + "  ,  " + d.pizza_size + "  ,  " + d.toppings + "  ,  " + d.qty + "  ,  " + d.price);


            Console.WriteLine();
            Console.WriteLine("//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$//");
            Console.WriteLine("END OF PROJECT!!!");
            Console.WriteLine("");



        }
    }
}
