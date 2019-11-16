using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cff
{

    class Program {
        static void Main(string[] args) {
            var codeReader = new CodeReader();
            Forth f = new Forth();
            System.Console.WriteLine("CF3 is being starting");

            while (Forth.isForthRunning) {
                f.Main(codeReader);
            }
            System.Console.WriteLine("Good bye");
        }
    }
}
