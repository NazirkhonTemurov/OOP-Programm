using System;


namespace ООП_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            MS_Word  file = new MS_Word
            {
                Name = "Родительный файл",
                Author = "Темуров Назирхон",
                KeyWords = "MS Word, PDF, MS Excel, TXT, HTML",
                Themes = "Хранение файлов разного типа",
                C_Documents = "C_Documents",
                Page = 20
            };

            file.Print();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_________________________________________________________");
            Console.ResetColor();
            Console.WriteLine();

            PDF pdf = new PDF
            {
                Name = "Родительный файл",
                Author = "Темуров Назирхон",
                KeyWords = "MS Word, PDF, MS Excel, TXT, HTML",
                Themes = "Хранение файлов разного типа",
                C_Documents = "C_Documents",
                DPI = 300
            };

            pdf.Print();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_________________________________________________________");
            Console.ResetColor();
            Console.WriteLine();

            TXT txt = new TXT
            {
                Name = "Родительный файл",
                Author = "Темуров Назирхон",
                KeyWords = "MS Word, PDF, MS Excel, TXT, HTML",
                Themes = "Хранение файлов разного типа",
                C_Documents = "C_Documents",
                SIZE = "123Kb"      
            };

            txt.Print();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_________________________________________________________");
            Console.ResetColor();
            Console.WriteLine();

            HTML html = new HTML
            {
                Name = "Родительный файл",
                Author = "Темуров Назирхон",
                KeyWords = "MS Word, PDF, MS Excel, TXT, HTML",
                Themes = "Хранение файлов разного типа",
                C_Documents = "C_Documents",
                Size = "1262Kb"
            };

            html.Print();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_________________________________________________________");
            Console.ResetColor();
            Console.WriteLine();

            MS_Excel excel = new MS_Excel
            {
                Name = "Родительный файл",
                Author = "Темуров Назирхон",
                KeyWords = "MS Word, PDF, MS Excel, TXT, HTML",
                Themes = "Хранение файлов разного типа",
                C_Documents = "C_Documents",
                Password = "Nazirkhon2003"
            };

            excel.Print();

            Console.ReadKey();
        }
    }
}
