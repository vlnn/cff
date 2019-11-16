using System;

class CodeReader : ICodeReader {
    public string ReadCode() {
        return (ReadLine.Read());
    }

    public string[] ParseCode(string nonParsedCode) {
        var parsedCode = nonParsedCode.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return parsedCode;
    }
}