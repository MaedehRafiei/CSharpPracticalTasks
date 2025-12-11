using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public static class NumberExtensions
    {
        public static IEnumerable<T> FilterNumbers<T>(this IEnumerable<T> numbers,Func<T, bool> condition)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentNullException(nameof(numbers));

            if (condition == null)
                throw new ArgumentNullException(nameof(condition));

            foreach (var item in numbers)
            {
                if (condition(item))
                    yield return item;
            }
        }
    }
}
