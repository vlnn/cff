using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cff {

    public class Cff {
        public static void Main(string[] args) {
            CodeReader codeReader = new CodeReader();
            Forth forth = new Forth();
            Interpret interpret = new Interpret(forth);

            while (Forth.isForthRunning) {
                interpret.Parse(codeReader);
            }
        }
    }
}
