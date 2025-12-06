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
            //Console.WriteLine("enter numbers");
            //var input = Console.ReadLine();
            //var numbers = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //var arrayNumbers = numbers.ToArray();


            //var result = Number.FilterNumbers(arrayNumbers);
            //Console.WriteLine("numbers Greater Than 5 is : " + string.Join(", ", result));
            //Console.ReadLine(); 
            
            
            
            Console.WriteLine("enter numbers");
            var input = Console.ReadLine();
            IEnumerable<int> numbers = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            
            var result = Number.FilterNumbers(numbers, n => n > 10 && n % 2 == 0);
            Console.WriteLine("numbers even and greater 10  : " + string.Join(", ", result));
            Console.ReadLine();

        }
    }
}
