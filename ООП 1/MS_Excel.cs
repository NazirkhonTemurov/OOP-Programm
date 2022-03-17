using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1
{
    class MS_Excel : Род_файл
    {
        public string Password;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MS_Excel");
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Пароль: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Password + "\n");
           
        }
    }
}
