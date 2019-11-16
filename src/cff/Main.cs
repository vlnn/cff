using System;

namespace cff {

    partial class Forth {

        public void Main() {
            string nonParsedCode = ReadCode();
            string[] parsedCode = ParseCode(nonParsedCode);
            foreach (string word in parsedCode) {
                if (!isCompiling) {
                    Console.Write("Running "); // 2do del
                    Console.WriteLine(word); // 2do del
                    Run(word);
                } else {
                    Console.Write("Compiling "); // 2do del
                    Console.WriteLine(word); // 2do del
                    Compile(word);
                };
            }
        }

        string ReadCode() {
            return (Console.ReadLine());
        }

        string[] ParseCode(string nonParsedCode) {
            var result = nonParsedCode.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return result;
        }
    }
}
