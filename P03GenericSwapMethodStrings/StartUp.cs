using System;
using System.Collections.Generic;
using System.Linq;

namespace P03GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> messages = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                messages.Add(message);
            }
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Box<string> box = new Box<string>(messages);
            box.Swap(indices[0], indices[1]);
            Console.WriteLine(box);
        }
    }
}
