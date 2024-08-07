using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Document document = new Document("Контракт");
            document.Body = "Тіло контракту...";
            document.Footer = "Директор: Іванов І.І.";

            document.Show();

            Console.ReadKey();
        }
    }
}
