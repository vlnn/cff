using System;

public class CodeReader : ICodeReader {
    string[] codeDelimiters = {" ", "\n"};

    public string ReadCode() {
        return (ReadLine.Read());
    }

    public string[] ParseCode(string nonParsedCode) {
        var parsedCode = nonParsedCode.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return parsedCode;
    }
}