﻿using System;

namespace ООП_1
{
    class MS_Word : Род_файл
    {
        public int Page;
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MS_Word");
            Console.ResetColor();
            base.Print();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Страница: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Page + "\n");
        }

    }
}
