using System;
using System.Threading;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " Тук Тук  -Кто это?  -Это я, твоя дверь  -Аа да  -А я думала Сова  -Индюк тоже думал и в щи попал";

            while (true)
            {
               
                for (int i = 0; i < 71; i++)
                {
                    string s = str.Substring(i, 20);
                    Console.WriteLine(s);
                    Thread.Sleep(60);
                    Console.SetCursorPosition(0, 0);

                }
            }
           
                
        }
    }
}
