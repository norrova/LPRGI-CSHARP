using System;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Asynchrone.CopyDirectory(
                "/Users/valentinnorro/Documents/LPRGI/LPRGI-CSHARP/Test Déplacement/Source",
                "/Users/valentinnorro/Documents/LPRGI/LPRGI-CSHARP/Test Déplacement/Dest"
            );
        }
    }
}
