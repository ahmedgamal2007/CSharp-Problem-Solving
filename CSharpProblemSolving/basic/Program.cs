namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            // problem1();
            problem2();
        }

        static void problem1()
        {
            int a = 5;
            int b = 10;
            int c = 15;

            int sum = a + b + c;

            System.Console.WriteLine($"The sum is: {sum}");
        }
             //***************************************************

            static void problem2()
            {
                int length = 8;
                int width = 4;
                int area = length * width;

                System.Console.WriteLine($"Rectangle Area: {area}");
            }



        }
    }

