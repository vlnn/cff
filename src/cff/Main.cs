using System;

namespace cff {

    partial class Forth {

        public void Main(CodeReader codeReader) {          
            string nonParsedCode = codeReader.ReadCode ();
            string[] parsedCode = codeReader.ParseCode (nonParsedCode);
            foreach (string word in parsedCode) {
                if (!isCompiling) {
                    System.Console.Write ("Running "); // 2do del
                    System.Console.WriteLine (word); // 2do del
                    Run (word);
                } else {
                    System.Console.Write ("Compiling "); // 2do del
                    System.Console.WriteLine (word); // 2do del
                    Compile (word);
                };
            }
        }
    }
}