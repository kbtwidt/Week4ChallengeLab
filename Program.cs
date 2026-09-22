namespace Week4ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            Console.WriteLine("Part 1");
            int number;
            Console.Write("Enter a whole number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Does {number} contain 3: " + IfNumberContains3(number));
            #endregion

            #region Part2
            Console.WriteLine("\nPart 2");
            int a, b, newNum;
            string message;
            Console.WriteLine("Provide two numbers:");
            Console.Write("Number 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            b = int.Parse(Console.ReadLine());
            newNum = DivisibleBy2Or3(a, b, out message);
            Console.WriteLine($"Numbers {a} & {b}:\n{message} {newNum}");
            #endregion

            #region Part3
            Console.WriteLine("\nPart 3");
            string input;
            char[] original, output;
            Console.Write("Enter a word to be reversed: ");
            input = Console.ReadLine();
            original = input.ToCharArray();
            output = ReverseString(original);
            Console.WriteLine($"{input} reversed is {new string(output)}"); 
            #endregion

        }

        static bool IfNumberContains3(int number)
        {
            while (number != 0)
            {
                if (Math.Abs(number % 10) == 3)
                    return true;
                else
                    number = number / 10;
            }
            return false;
        }

        static int DivisibleBy2Or3(int a, int b, out string message)
        {
            if ((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))
            {
                message = "Both numbers are divisible by 2 or 3, Product: ";
                return a * b;
            }

            message = "One or both numbers not divisible by 2 or 3, Sum: ";
            return a + b;
        }

        static char[] ReverseString(char[] input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                char temp = input[left];
                input[left] = input[right];
                input[right] = temp;
                left++;
                right--;
            }
            return input;
        }
    }
}
