using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace review
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Review2
    {
        static void Main(string[] args)
        {
            UserInputAndSwitchStatements();
            GetDayOfWeek();
            GetDayOfWeekEnum();
            DynamicLoops();
            ArrraysAndLoops();
            BreaksAndContinues();
            MoreLoops();
            MultidimensionalArrays();

            //methods
           //int[] intArray = { 1, 2, 3, 4, 5 };
           //Console.WriteLine("Sum is" + SumValues(intArray));
           //float[] floatArray{ 1.0f, 2.5f, 4.0f 5.5f };
           //Console.WriteLine("Sum is" + SumValues(floatArray));
           //double[] doubleArray{ 1.0, 3.25, 5.5, 7.75};
           //Console.WriteLine("Sum is" + SumValues(doubleArray));
        }

        private static int SumValues(int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return sum;
        }



        private static void UserInputAndSwitchStatements()
        {
            Console.WriteLine("Enter your name");
            string? name = Console.ReadLine();
            if(name != null)
            {
                Console.WriteLine("Your name is " + name);
            }

            Console.WriteLine("Enter the number of people in the class");
            //int numPeople = convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter a number with decimal points");
            string? stringWithDecimal = Console.ReadLine();
            if (stringWithDecimal != null)
            {
                float numWithDecimal = float.Parse(stringWithDecimal); 
            }
        }

        private static void GetDayOfWeek()
        {
            Console.WriteLine("What day of the week is it? (Enter a number 0-6 inslusive)");
            ConsoleKeyInfo inputKey = Console.ReadKey(); //get a single key
            int.TryParse(inputKey.KeyChar.ToString(), out int result);
            Console.ReadLine();
            switch (result)
            {
                case 0: 
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }

        private static void GetDayOfWeekEnum()
        {
            foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day.ToString());
            }

            DayOfWeek[] days = (DayOfWeek[])Enum.GetValues(typeof(DayOfWeek));
            for(int i =0; i < days.Length; i++)
            {
                Console.WriteLine(days[i].ToString());
            }
            Console.WriteLine();

            Console.WriteLine("What day of the week is it? (Enter a number 0-6 inclusive)");
            ConsoleKeyInfo inputKey = Console.ReadKey();
            int.TryParse(inputKey.KeyChar.ToString(), out int result);
            Enum dayOfWeek = (DayOfWeek) result;
            Console.WriteLine();

            switch(dayOfWeek)
            {
                case DayOfWeek.Sunday:
                 Console.WriteLine("Sunday");
                 break;
                case DayOfWeek.Monday:
                 Console.WriteLine("Monday");
                 break;
                case DayOfWeek.Tuesday:
                 Console.WriteLine("Tuesday");
                 break;
                case DayOfWeek.Wednesday:
                 Console.WriteLine("Wednesday");
                 break;
                case DayOfWeek.Thursday:
                 Console.WriteLine("Thursday");
                 break;
                case DayOfWeek.Friday:
                 Console.WriteLine("Friday");
                 break;
                case DayOfWeek.Saturday:
                 Console.WriteLine("Saturday");
                 break;
                default:
                 Console.WriteLine("Did not put a number 0-7");
                 break;

            }
        }

        private static void DynamicLoops()
        {
            Console.WriteLine("Input lnegth of array");
            int arrayLength = (int)Console.Read();
            Console.WriteLine("Input Max randow value for array");
            int maxRandomValue = (int)Console.Read();
            int[] array= new int[arrayLength];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
              array[i] = rnd.Next(maxRandomValue);
            }

        }

        private static void ArrraysAndLoops()
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            float[] floatArray = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };

            // outputs all elements of the array
            int intArrayIndex = 0;
            while (intArrayIndex < intArray.Length)
            {
                Console.WriteLine("while: " + intArray[intArrayIndex++]);
                intArrayIndex++;
            }

            intArrayIndex = 0;
            do
            {
                Console.WriteLine("do:" + intArray[intArrayIndex]);
                intArrayIndex++;
            } while (intArrayIndex < intArray.Length);

            // outputs all elements of the array. 
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("for: " + intArray[i]);
            }

            foreach (float i in intArray)
            {
                Console.WriteLine("foreach: " + i);
            }
        }

        static void MultidimensionalArrays()
        {
            Console.WriteLine("Input length of array");
            int arrayLength = (int)Console.Read();
            Console.WriteLine("Input Max random value for array");
            int maxRandomValue = (int)Console.Read();
            int[] array = new int[arrayLength];
            Random rnd = new Random();
            for(int i =0; i < array.Length; i++)
            {
                array[i] = rnd.Next(maxRandomValue);
            }
        }

        private static void BreaksAndContinues()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < intArray.Length; i++)
            {
                if (1 % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }
            foreach (int x in intArray)
            {
                if (x == 3)
                {
                    break;
                }
                Console.WriteLine(intArray[x]);
            }

        }

        private static void MoreLoops()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < intArray.Length; i++)
            {
                if(i == intArray.Length / 2)
                {
                    Console.WriteLine(intArray[i]);
                }
            }
            Random rnd = new Random();
            int randomIndex = 0;
            int loopEscapeNumber = 3;

            randomIndex = rnd.Next(intArray.Length);
            Console.WriteLine("Guess to Escape: " + intArray[randomIndex]);

            while (intArray[randomIndex] != loopEscapeNumber)
            {
                randomIndex = rnd.Next(intArray.Length);
                Console.WriteLine("Guess to Escape: " + intArray[randomIndex]);
            }
            Console.WriteLine("Escape successful! Answer was: " + intArray[randomIndex]);

            //add up all elements of an array in for loop
            int sum = 0;
            for(int i=0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            Console.WriteLine("Sum from the loop: " + sum);

            //add up all elements of an array in a foreach loop
            foreach(int x in intArray)
            {
                sum += x;
            }
            Console.WriteLine("Sum from te loop: " + sum);
        }
    }
}
