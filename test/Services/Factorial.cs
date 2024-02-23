namespace test.Services
{
    public class Factorial
    {
        public int factorialcal(int number) 
        {
            var result = 0;
            if (number is not 0)
            {
                result = number;
                for (int i = number-1; i > 0; i--)
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
