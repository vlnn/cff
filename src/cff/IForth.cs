public interface IForth {
    static bool isCompiling { get; }
    static bool isForthRunning { get; }

    void Run(string word);
    void Compile(string word);

}
