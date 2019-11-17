using System;
using System.Collections.Generic;

namespace cff {

    partial class Forth : IForth {
        // the program is running
        static private bool isForthRunning { get; set; }

        // true if FORTH is in compile mode, false if in running
        private bool isCompiling { get; set; }

        // Dict is main FORTH words dictionary
        Dictionary<string, string[]> Dict = new Dictionary<string, string[]>() {
            { "die",  new[] { "drop", "bye"} } // example how to inline forth code
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

        public bool IsCompiling(){
            return isCompiling;
        }

        public bool IsForthRunning(){
            return isForthRunning;
        }
    }
}
