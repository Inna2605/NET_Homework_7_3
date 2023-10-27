//Завдання 3: Додайте до першого завдання реалізацію інтерфейсу IDisposable.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Play play = new Play("Назва п'єси", "Автор п'єси", "Жанр п'єси", "Рік написання п'єси");
            Console.WriteLine($"П'єса: {play.NamePlay} {play.FullNameAuthor} {play.Genre} {play.Year}");

            //play.Dispose();//безпосередньо виклик методу Dispose() через об'єкт

            using (play)
            {
                Console.WriteLine("\n\nВідпрацювання конструкції using");
            }

            Console.ReadLine();
        }
    }
}
