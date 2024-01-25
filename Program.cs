using Snakey;
using static System.Net.Mime.MediaTypeNames;

namespace Snakey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < (int)Border.height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
                Console.SetCursorPosition((int)Border.width, i);
                Console.WriteLine("|");
            }
            for (int i = 1; i < (int)Border.width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("-");
                Console.SetCursorPosition(i, (int)Border.height);
                Console.WriteLine("-");
            }
            Snaker peton = new Snaker();
            peton.snuk();
            Console.WriteLine("Поражение");
        }
    }
}