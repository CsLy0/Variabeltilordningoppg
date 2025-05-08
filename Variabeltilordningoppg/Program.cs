namespace Variabeltilordningoppg
{

    internal class Program
    {
        int tall = 1;

        float desimalTall = 1.01F;
        double desimalTall2 = 1.01;
        decimal desimalTall3 = 1.01M;

        char bokstav = 'a';
        string tekst = "Hei";

        bool santUsant = true;

        int[] tallArray = { 1, 2, 3 };
        string[] tekstArray = { "Hei", "på", "deg" };

        List<int> listeMedTall = new List<int>();

        public string ReturnString()
        {
            return "Hello, World!";
        }

        public int ReturnWholeNumber()
        {
            return 5;
        }

        public double ReturnDouble()
        {
            return 5.5;
        }

        public double DoubleSum()
        {
            return 10.5;
        }

        public bool trueFalse()
        {
            return true;
        }

        public void Run()
        {

            Console.WriteLine($"Dette er en string: {ReturnString()}");
            Console.WriteLine($"Dette er en int: {ReturnWholeNumber()}");
            Console.WriteLine($"Dette er en string:{ReturnDouble()}");
            Console.WriteLine($"Dette er en string:{trueFalse()}");
            Console.WriteLine($"{DoubleSum()} er summen av {ReturnWholeNumber()} + {ReturnDouble()}");
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
    }
}





