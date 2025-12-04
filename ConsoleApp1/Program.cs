using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers");
            var input = Console.ReadLine();
            var numbers = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var result = Number.FilterNumbers(numbers);
            Console.WriteLine("numbers Greater Than 5 is : " + string.Join(", ", result));
            Console.ReadLine();

        }
    }
}
