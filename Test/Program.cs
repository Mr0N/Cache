using BufferEnumerable;
using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterator = new Iterator<int>(Enumerable.Range(1,10).Select(a=>a+1));
            int count = 0;
            foreach (var item in iterator)
            {
                count++;
                if (count == 4) break;
                Console.WriteLine($"{count})" + item);
            }
            Console.WriteLine(new string('-', 50));
            foreach (var item in iterator)
            {
                count++;
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
