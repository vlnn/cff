using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cff {

    class Program {
        static void Main(string[] args) {
            CodeReader codeReader = new CodeReader();
            Forth forth = new Forth();
            Interpret interpret = new Interpret(forth);

            System.Console.WriteLine("CFF is being starting");

            while (Forth.isForthRunning) {
                interpret.Parse(codeReader);
            }
            System.Console.WriteLine("Good bye");
        }
    }
}
