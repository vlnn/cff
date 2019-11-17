public interface IForth {

    bool isCompiling { get; }
    static bool isForthRunning { get; }

    void Run(string word);
    void Compile(string word);

}
