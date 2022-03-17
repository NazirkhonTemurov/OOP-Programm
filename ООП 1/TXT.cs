using System;

namespace ООП_1
{
    class TXT : Род_файл
    {
        public string SIZE;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TXT");
            Console.WriteLine();
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Размер: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(this.SIZE + "\n");
        }
    }
}
