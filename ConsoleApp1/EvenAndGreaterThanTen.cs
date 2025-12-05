using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    public class EvenAndGreaterThanTen : IFilterCondition
    {
        public bool IsMatch(int number)
        {
            return number > 10 && number % 2 == 0;
        }
    }
}
