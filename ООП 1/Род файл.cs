using System;

namespace ООП_1
{
    abstract class Род_файл 
    {
        
        public string Name;
        public string Author;
        public string KeyWords;
        public string Themes;
        public string C_Documents;
        public virtual void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Имя Файла: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Name+"\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Автор: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Author + "\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ключевое слово: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.KeyWords + "\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Тема: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Themes + "\n");

            

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Путь к Файлу: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.C_Documents + "\n");
            
            Console.ResetColor();
        }

    }
   
}
