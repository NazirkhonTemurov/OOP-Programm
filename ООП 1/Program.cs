using System;


namespace ООП_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Род_файл file = new Род_файл
            {
                Name = "Имя|Родительный файл",
                Author = "Автор|Темуров Назирхон",
                KeyWords = "Ключевое слово|MS Word, PDF, MS Excel, TXT, HTML",
                Themes = "Тема|Хранение файлов разного типа",
                C_Documents = "Путь к Файлу|C_Documents"
            };




            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Родительный файл");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(file.Name);
            Console.WriteLine(file.Author);
            Console.WriteLine(file.KeyWords);
            Console.WriteLine(file.Themes);
            Console.WriteLine(file.C_Documents);
            Console.ResetColor();
            //MS Word
            MS_Word MS_Word = new MS_Word
            {
                NameDoc = "MS Word"
            };

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(MS_Word.NameDoc);
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
