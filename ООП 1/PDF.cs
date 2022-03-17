using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1
{
    class PDF : Род_файл
    {
        public int DPI;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PDF");
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("DPI: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.DPI + "\n");
        }
    }
}
