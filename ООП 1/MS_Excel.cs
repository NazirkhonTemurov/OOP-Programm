using System;

namespace ООП_1
{
    class MS_Excel : Род_файл
    {
        public string Password;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MS_Excel");
            Console.WriteLine();
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Пароль: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(this.Password + "\n");
           
        }
    }
}
