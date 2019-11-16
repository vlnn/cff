using System;

namespace cff {

    class Program {
        static void Main(string[] args) {
            Forth f = new Forth();
            Console.WriteLine("CF3 is being starting");

            while (Forth.isForthRunning) {
                f.Main();
            }
            Console.WriteLine("Good bye");
        }
    }
}
