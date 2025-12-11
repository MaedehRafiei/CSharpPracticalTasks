using System;
using System.Collections.Generic;
using System.Linq;

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


        public static List<int> FilterNumbers(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentNullException("numbers is null");

            return numbers.Where(n => n > 5).ToList();

        }


        public static List<object> FilterNumbers(IEnumerable<object> numbers, Func<object, bool> condition)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentNullException("numbers is null");

            if (condition == null)
                throw new ArgumentNullException("filterCondition is null");

            List<object> result = new List<object>();


            foreach (var item in numbers)
            {
                if (condition(item))
                    result.Add(item);
            }

            return result;

        }


        public static IEnumerable<T> FilterNumbers<T>(IEnumerable<T> numbers, Func<T, bool> condition)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentNullException("numbers is null");

            if (condition == null)
                throw new ArgumentNullException("filterCondition is null");

            foreach (var item in numbers)
            {
                if (condition(item))
                    yield return item;
            }
        }

    }
}
