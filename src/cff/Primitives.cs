using System;
using System.Collections.Generic;

namespace cff {

    partial class Forth : IForth {

        // Primi is main FORTH primitives (i.e. purely C# defined) dictionary
        Dictionary<string, Action> Primi = new Dictionary<string, Action>() { 
            { "nop", fNop }, 
            { "dup", fNop }, 
            { "bye", fBye },
        };

        static Action fNop = () => {};
        
        static Action fBye = () => {
            System.Console.Write("CYA");
            isForthRunning = false;
        };
    }
}
