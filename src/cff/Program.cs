using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cff
{

    class Program {
        static void Main(string[] args) {
            var codeReader = new CodeReader();
            Forth forth = new Forth();
            var parser = new Interpret(forth);

            System.Console.WriteLine("CF3 is being starting");

            while (forth.isForthRunning) {
                parser.Parse(codeReader);
            }
            System.Console.WriteLine("Good bye");
        }
    }
}
