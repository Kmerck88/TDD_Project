namespace FirstTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 7;
            int sumResult = CalculateSum(firstNumber, secondNumber);
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sumResult}.");
        }

        // Moved the CalculateSum method into the Program class
        public static int CalculateSum(int firstNumber, int secondNumber) => firstNumber + secondNumber;
    }
}
