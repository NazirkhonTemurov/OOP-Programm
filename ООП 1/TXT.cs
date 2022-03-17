using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1
{
    class TXT : Род_файл
    {
        public string SIZE;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TXT");
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Размер: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.SIZE + "\n");
        }
    }
}
