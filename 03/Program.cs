using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        // Створіть 2 інтерфейси IPlayable та IRecodable.
        // У кожному з інтерфейсів створіть по 3 методи void Play() / void Pause() / void Stop()
        // та void Record() / void Pause() / void Stop() відповідно.
        // Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable.
        // Написати програму, яка виконує програвання та запис.
        
        
        
        interface IPlayable
        {
            void Pause();
            void Stop();
            void Play();
        }

        interface IRecordable : IPlayable
        {
            new void Pause();
            new void Stop();
            void Record();
        }

        

        class Player : IPlayable, IRecordable
        {
            public void Pause()
            {
                Console.WriteLine("Пауза");
            }

            public void Stop()
            {
                Console.WriteLine("Зупинка");
            }

            


            public void Play()
            {
                Console.WriteLine("Програвання");
            }

            public void Record()
            {
                Console.WriteLine("Запис");
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Player player = new Player();


            (player as IPlayable).Play();
            (player as IPlayable).Pause();
            (player as IPlayable).Stop();
            Console.WriteLine(new string('-', 30));

            (player as IRecordable).Play();
            (player as IRecordable).Record();
            (player as IRecordable).Pause();
            (player as IRecordable).Stop();


            Console.ReadKey();
        }
    }
}
