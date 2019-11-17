using NUnit.Framework;
using Shouldly;

namespace NUnit.Tests
{
    [TestFixture]
    public class CodeReaderTest
    {
        public CodeReader codeReader = new CodeReader();

        [Test]
        public void ParseSimpleLine()
        {
            codeReader.ParseCode("one two   three").ShouldBe(new[] { "one", "two", "three" });
        }

        [Test]
        public void ParseSeveralLines()
        {
            codeReader.ParseCode("one  two \n three").ShouldBe(new[] { "one", "two", "three" });
        }
        
        [Test]
        public void ParseDoesntChangeRegister()
        {
            codeReader.ParseCode("oNe  tWo THREE").ShouldBe(new[] { "oNe", "tWo", "THREE" });
        }
    }
}
