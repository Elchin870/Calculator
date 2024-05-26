namespace Calculator
{
    internal class Program
    {

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            var a=Console.ReadLine();
            Console.WriteLine("Enter operator: ");
            var op= Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            var b=Console.ReadLine();

            switch (Convert.ToChar(op))
            {
                case '+':
                    int plus=Addition(Convert.ToInt32(a), Convert.ToInt32(b));
                    Console.Write("Cavab: ");
                    Console.WriteLine(plus);
                    break;

                case '*':
                    int vurma= Multiplication(Convert.ToInt32(a), Convert.ToInt32(b));
                    Console.Write("Cavab: ");
                    Console.WriteLine(vurma);
                    break;

                case '-':
                    int cixma= Subtraction(Convert.ToInt32(a), Convert.ToInt32(b));
                    Console.Write("Cavab: ");
                    Console.WriteLine(cixma);
                    break;

                case '/':
                    double bolme= Division(Convert.ToDouble(a), Convert.ToDouble(b));
                    Console.Write("Cavab: ");
                    Console.WriteLine(bolme);
                    break;

                default:
                    Console.WriteLine("Wrong input!!!");
                    break;
            }

            
        }
    }


}
