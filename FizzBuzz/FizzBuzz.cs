namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        public string Convert(int number)
        {
            if (IsMultipleOf(number, 15))
            {
                return FIZZ + BUZZ;
            }

            if (IsMultipleOf(number, 3))
            {
                return FIZZ;
            }

            if (IsMultipleOf(number, 5))
            {
                return BUZZ;
            }

            return number.ToString();
        }

        private bool IsMultipleOf(int number, int factor)
        {
            return number % factor == 0;
        }
    }
}
