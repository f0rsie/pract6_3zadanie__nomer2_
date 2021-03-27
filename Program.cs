using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace pract6_3zadanie__nomer2_
{
    class Program
    {
        static void Main()
        {
            var f = new FileStream("f.txt", FileMode.Open, FileAccess.Read);
            var g = new byte[f.Length];
            int count = 0;
            for (int i = 0; i < f.Length; i++)
            {
                char k = (char)f.ReadByte();
                if (Char.IsNumber(k) == true)
                {
                    count++;
                }
                WriteLine(k);
            }
            WriteLine($"Количество цифр в файле: {count}");
            ReadKey();
        }
    }
}
