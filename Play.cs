//Завдання 3: Додайте до першого завдання реалізацію інтерфейсу IDisposable.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET_Homework_7_3
{
    internal class Play: IDisposable
    {
        public string NamePlay;
        public string FullNameAuthor;
        public string Genre;
        public string Year;
        public Play(string N, string A, string G, string Y)
        {
            NamePlay = N;
            FullNameAuthor = A;
            Genre = G;
            Year = Y;
        }
        ~Play()
        {
            Console.WriteLine("\nВідпрацювання фіналізатора.");
            Thread.Sleep(600000);//Затримка часу спрацювання фіналізатора
        }
        public void Dispose()
        {
            Console.WriteLine("\n\nВідпрацювання метода Dispose()");
        }
    }
}
