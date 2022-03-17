using System;

namespace ООП_1
{
    class MS_Word : Род_файл
    {
        public int Page;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MS_Word");
            Console.WriteLine();
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Страница: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(this.Page + "\n");
        }

    }
}
