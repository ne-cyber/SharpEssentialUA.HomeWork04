using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {


        //Створити клас AbstractHandler.
        //У тілі класу створити методи void Open(), void Create(), void Change(), void Save().
        //Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler.
        //Написати програму, яка виконуватиме визначення документа і для кожного формату мають бути методи відкриття,
        //створення, редагування, збереження певного формату документа.


        // Абстрактний класс (абстракція) 
        abstract class AbstractHandler
        {
            public abstract void Open();            
            public abstract void Create();
            public abstract void Change();
            public abstract void Save();
        }

        // Конкретний клас
        class XMLHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("XML файл відкрито.");
            }

            public override void Create()
            {
                Console.WriteLine("XML файл створено.");
            }

            public override void Change()
            {
                Console.WriteLine("XML файл змінено.");
            }

            public override void Save()
            {
                Console.WriteLine("XML файл сбережено.");
            }
        }



        class TXTHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("текстовий файл відкрито.");
            }

            public override void Create()
            {
                Console.WriteLine("текстовий файл створено.");
            }

            public override void Change()
            {
                Console.WriteLine("текстовий файл змінено.");
            }

            public override void Save()
            {
                Console.WriteLine("текстовий файл сбережено.");
            }
        }



        class DOCHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("DOC файл відкрито.");
            }

            public override void Create()
            {
                Console.WriteLine("DOC файл створено.");
            }

            public override void Change()
            {
                Console.WriteLine("DOC файл змінено.");
            }

            public override void Save()
            {
                Console.WriteLine("DOC файл сбережено.");
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            AbstractHandler handler;

            handler = new XMLHandler();
            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
            Console.WriteLine(new string('-', 30));

            handler = new TXTHandler();
            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
            Console.WriteLine(new string('-', 30));


            handler = new DOCHandler();
            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
            Console.WriteLine(new string('-', 30));

            Console.ReadKey();
        }

    }
}

