using System;
using System.Collections.Generic;

namespace heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Ikea v_ikea = new Ikea("Lille", new List<Meuble>() {
                new Table(3.43, 23.23, 12.00),
                new Bureau(3.43, 23.23, 12.00),
                new Buffet(3.43, 23.23, 12.00)
            });
            Console.WriteLine(v_ikea.ListerLesProduits());
        }
    }
}
