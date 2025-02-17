namespace CSharpMethods
{
    internal class CSharpMethods
    {
        static void Main(string[] args)
        {
            int AddFunctions(int a, int b) //local function
            {
                Console.WriteLine(a + b);
                return a + b;
            }

            Console.WriteLine(AddFunctions(3, 5));

            int x = 1, y = 2;
            int sumXY = AddFunctions(x, y);

            sumXY = 0;
            Console.WriteLine(AddFunctions(b: x, a: y));
            sumXY = CSharpMethods.AddFunctions(x, y);

            DivideFunction(x, y);
            DivideFunction(b: x, a: y);

            int a = 5;
            SquareInput(ref a);
            Console.WriteLine(a);

            if (DivideFunction(x, y, out float QuotientOutput1))
            {
                Console.WriteLine(QuotientOutput1);
            }

            if (DivideFunction(a: x, b: y, out float QuotientOutput2))
            {
                Console.WriteLine(QuotientOutput1);
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            FoundIndexOutOfNumbers(numbers, 3, out int index);
            Console.WriteLine("Index of the number is 3: " + index);
            Speak("hello");
            Speak();
        }

        static int AddFunctions(int a, int b)
        {
            Console.WriteLine("Global add: " + a + b);
            return a + b;
        }
        static void SquareInput(ref int a)
        {
            a *= a;
        }

        static void DivideFunction(float a, float b)
        {
            if(b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Divide by zero");
            }
        }

        static bool DivideFunction(float a, float b, out float quotient)
        {
            if (b != 0)
            {
                quotient = a / b;
                Console.WriteLine(quotient);
                return true;
            }
            else
            {
                quotient = 0;
                Console.WriteLine("Divide by zero");
                return false;
            }
        }

        static bool FoundIndexOutOfNumbers(int[] numbers, int number, out int index)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    Console.WriteLine(i);
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }
        static void Speak(string wordToSpeak = "Bork")
        {
            Console.WriteLine(wordToSpeak);
        }
    }
}
