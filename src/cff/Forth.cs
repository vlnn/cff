using System;
using System.Collections.Generic;

namespace cff {

    partial class Forth : IForth {
        // the program is running
        public bool isForthRunning { get; set; }

        // FORTH is in compile mode (in running if false)
        public bool isCompiling { get; set; }

        // Dict is main FORTH words dictionary
        static Dictionary<string, string[]> Dict = new Dictionary<string, string[]>() {
            ["bye"] = (new string[1] { "bye" }),
        };

        // Primi is main FORTH primitives dictionary
        static Dictionary<string, Action> Primi = new Dictionary<string, Action>() {
            ["nop"] = fNop, ["dup"] = fNop
        };

        public Forth(){
            isForthRunning = true;
            isCompiling = false;
        }
        public void Compile(string word) {}

        public void Run(string word) {
            if (Find(word).Length != 0) {
                if (!TryRunPrimitive(word)) {
                    foreach (string w in Find(word)) {
                        Run(w);
                    }
                }
            }
        }

        bool TryRunPrimitive(string word) {
            // find and run primitive
            if (Primi.ContainsKey(word)) {
                Primi[word].Invoke();
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
