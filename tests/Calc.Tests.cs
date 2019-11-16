using calc;
using NUnit.Framework;
using Shouldly;

namespace tests {
    public class Tests {
        private Calc calc = new Calc();

        [SetUp]
        public void Setup() {}

        [Test]
        public void AddReturnsZeroForEmpty() {
            var zero = calc.Add("");
            zero.ShouldBe(0);
        }

        [Test]
        public void AddReturnsZeroForZero() {
            var zero = calc.Add("0");
            zero.ShouldBe(0);
        }

        [Test]
        public void AddReturns121For121() {
            var onetwoone = calc.Add("121");
            onetwoone.ShouldBe(121);
        }

        [Test]
        public void Add2And2() {
            var result = calc.Add("2,2");
            result.ShouldBe(4);
        }

        [Test]
        public void Add2And2And3() {
            var result = calc.Add("2,2,3");
            result.ShouldBe(7);
        }

        [Test]
        public void Add2And2AndNegative3() {
            var result = calc.Add("2,2,-3");
            result.ShouldBe(1);
        }

        [Test]
        public void NegativeResult() {
            var result = calc.Add("2,-3");
            result.ShouldBe(-1);
        }

        [Test]
        public void CharsIgnored() {
            var result = calc.Add("fsdoifj,3,sodijf,2");
            result.ShouldBe(5);
        }

        [Test]
        public void EmptyArgsIgnored() {
            var resultEmpties = calc.Add(",,,,3,,,,,,2,,,,");
            var resultFullies = calc.Add("3,2");
            resultEmpties.ShouldBe(resultFullies);
        }

        [Test]
        public void AddSeveralLines() {
            var result = calc.Add("2\n,,3\n2\n");
            result.ShouldBe(7);
        }

        [Test]
        public void OptionalDelimsDoNotChangeResults() {
            var result = calc.Add("//;.,a\n3,2,1");
            result.ShouldBe(calc.Add("3,2,1"));
        }

        [Test]
        public void OptionalDelimsAreUsed() {
            var result = calc.Add("//;a\n3a2;1");
            result.ShouldBe(calc.Add("3,2,1"));
        }
    }
}
