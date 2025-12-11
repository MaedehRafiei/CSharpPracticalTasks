using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Extentions
{
    public static class NumberExtensions
    {
        public static IEnumerable<T> FilterNumbers<T>(this IEnumerable<T> numbers, IFilterCondition<T> condition)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            if (condition == null)
                throw new ArgumentNullException(nameof(condition));

            foreach (var item in numbers)
            {
                if (condition.IsMatch(item))
                    yield return item;
            }
        }
    }
}
