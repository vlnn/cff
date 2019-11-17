public interface IForth {
    static bool isCompiling { get; }
    static bool isForthRunning { get; }

    bool IsCompiling();
    bool IsForthRunning();
    void Run(string word);
    void Compile(string word);

}
