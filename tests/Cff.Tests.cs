using cff;
using NUnit.Framework;
using Moq;
using Shouldly;

namespace NUnit.Tests {
    [TestFixture]
    public class CffTest {

        Cff program = new Cff();

        [Test]
        public void CffCanExit() {
            var Forth = new Mock<IForth>();
            var Interpret = new Mock<IInterpret>();
            var CodeReader = new Mock<CodeReader>();
            Forth.Setup(m => m.IsForthRunning()).Returns(false);
            CodeReader.Setup(m => m.ReadCode()).Returns("dup drop bye");

            // Cff.Main(new[]{"null"});

           // Interpret.Verify( m => m.Parse(CodeReader.Object), Times.Never);
        }
    }
}
