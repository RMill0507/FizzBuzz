namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public string FizzBuzz(int number)
        {
            var answer = "";
            if (number % 3 == 0)
            {
                answer = "fizz";
            }
            if (number % 5 == 0)
            {
                answer += "buzz";
            }

            return answer;
        }
    }
}