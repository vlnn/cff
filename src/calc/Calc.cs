using System;

namespace calc {
    public class Calc {
        private int parsedint;
        private int sum;

        public int Add(string args) {
            var separators = GetOptionalSeparators(args);
            var results = args.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            sum = 0;
            foreach (string number in results) {
                if (int.TryParse(number, out parsedint)) {
                    sum += parsedint;
                }
            }
            return sum;
        }

        private string[] GetOptionalSeparators(string args) {
            return (new string[]{",","\n","a",";"});
        }
    }
}
