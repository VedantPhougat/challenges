using static System.Console;
using Challenges.DataStructures;

namespace Coding
{
    public class Program
    {
        private static readonly DataStructure Structure;

        static Program()
        {
            Structure = new DataStructure();
        }

        public static void Main(string[] args)
        {
            Structure.ArrayInReverse();

            WriteLine("\nPress Enter key to exit...");
            ReadKey();
        }
    }
}
