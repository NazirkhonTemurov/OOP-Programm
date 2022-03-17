using System;

namespace ООП_1
{
    class PDF : Род_файл
    {
        public int DPI;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PDF");
            Console.WriteLine();
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("DPI: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(this.DPI + "\n");
        }
    }
}
