using System.ComponentModel;

namespace IMAT_GitTest
{
    internal class Program
    {
        public static int Add(int x, int y)
        {  return x + y; }
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;
            int suma = Add(x, y);
            Console.WriteLine($"Numero resultante {suma}");
        }
    }
}