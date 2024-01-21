namespace Week2.app1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float firstNumber;
            float secondNumber;
            Console.WriteLine("Please enter first number");
            firstNumber= float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            secondNumber = float.Parse(Console.ReadLine());

            

            float resaultSum = firstNumber + secondNumber;

            Console.WriteLine("adition result :" +resaultSum);

            float resaultMultipi = firstNumber * secondNumber;

            Console.WriteLine("Multipi " + resaultMultipi);

            float resaultMinus = firstNumber - secondNumber;

            Console.WriteLine("Minus " + resaultMinus);

            float resaultDivide = firstNumber / secondNumber;

            Console.WriteLine("Divide " + resaultDivide);




        }
    }
}