using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();

            for (int i = 1; i < 100; i++)
            {
                numbers.Add (random.Next(0, 50));
               
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            List<int> less_than_ten = numbers.Where(x => x < 10).ToList();
            less_than_ten.ForEach(x => Console.WriteLine(x));

            List<int> divided_by_three = numbers.Where(x => x%3==0).ToList();
            divided_by_three.ForEach(x => Console.WriteLine(x));

            List<int> even_and_bigger_than_20 = numbers.Where(x => x%2 == 0 && x>20).ToList();
            even_and_bigger_than_20.ForEach(x => Console.WriteLine(x));

            List<int> arising_order_list = numbers.OrderBy(x=>x).ToList();
            arising_order_list.ForEach(x => Console.WriteLine(x));

        }
    }
}
