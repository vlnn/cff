public interface IForth{

    bool isCompiling {get;}
    bool isForthRunning {get;}

    void Run(string word);
    void Compile(string word);

}