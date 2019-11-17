using System;

namespace cff {

    class Parser {
        protected IForth Forth;
        public Parser(IForth forth) {
            Forth = forth;
        }
        public void Parse(CodeReader codeReader) {
            string nonParsedCode = codeReader.ReadCode();
            string[] parsedCode = codeReader.ParseCode(nonParsedCode);
            foreach (string word in parsedCode) {
                if (!Forth.isCompiling) {
                    System.Console.Write("Running "); // 2do del
                    System.Console.WriteLine(word); // 2do del
                    Forth.Run(word);
                } else {
                    System.Console.Write("Compiling "); // 2do del
                    System.Console.WriteLine(word); // 2do del
                    Forth.Compile(word);
                };
            }
        }
    }
}
