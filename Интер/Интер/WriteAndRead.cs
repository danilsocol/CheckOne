using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Интер
{
    class WriteAndRead 
    {
        public static string[] Read() 
        {
            return File.ReadAllLines("kod.txt");
        }

        public static void Write() 
        {
            Console.WriteLine("Ошибка");
        }

    }
}

