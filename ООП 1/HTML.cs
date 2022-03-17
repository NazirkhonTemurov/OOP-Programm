using System;

namespace ООП_1
{
    class HTML : Род_файл
    {
        public string Size;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HTNL");
            Console.WriteLine();
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Размер: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(this.Size + "\n");
        }
    }
}
