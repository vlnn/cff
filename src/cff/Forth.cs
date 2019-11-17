using System;
using System.Collections.Generic;

namespace cff {

    partial class Forth : IForth {
        // the program is running
        public bool isForthRunning { get; set; }

        // true if FORTH is in compile mode, false if in running
        public bool isCompiling { get; set; }

        // Dict is main FORTH words dictionary
        Dictionary<string, string[]> Dict = new Dictionary<string, string[]>() {
            // { "bye",  new[] { "drop", "bye"} } // example how to inline forth code
        };

        // Primi is main FORTH primitives dictionary
        Dictionary<string, Action> Primi = new Dictionary<string, Action>() { { "nop", fNop }, { "dup", fNop }, { "bye", fBye },
        };

        public Forth() {
            isForthRunning = true;
            isCompiling = false;
        }
        public void Compile(string word) {}

        public void Run(string word) {
            TryRunPrimitive(word);
            if (Find(word).Length != 0) {
                foreach (string w in Find(word)) {
                    Run(w);
                }
            }
        }

        bool TryRunPrimitive(string word) {
            Console.WriteLine("key is " + word);
            // find and run primitive
            if (Primi.ContainsKey(word)) {
                Console.WriteLine("invoking");
                Primi[word].Invoke();
                Console.WriteLine("invoken");
                return true;
            }
            return false;
        }

        string[] Find(string word) {
            if (Dict.ContainsKey(word)) {
                return (Dict[word]);
            } else {
                return (new string[0]);
            }
        }

        static Action fNop = () => {};
        static Action fBye = () => { System.Console.Write("CYA"); };
    }
}
