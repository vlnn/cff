using System;

public class CodeReader : ICodeReader {
    string[] codeDelimiters = { " ", "\n" };

    public virtual string ReadCode() {
        return (ReadLine.Read());
    }

    public string[] ParseCode(string nonParsedCode) {
        var parsedCode = nonParsedCode.Split(codeDelimiters, StringSplitOptions.RemoveEmptyEntries);
        return parsedCode;
    }
}
