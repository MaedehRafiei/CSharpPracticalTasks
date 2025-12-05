using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Number
    {
        public static List<int> FilterNumbers(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentNullException("numbers is null");

            return numbers.Where(n => n > 5).ToList();

        }
    }
}
