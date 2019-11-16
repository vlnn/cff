using cff;
using NUnit.Framework;
using System;
using System.IO;
using Moq;
using Shouldly;

namespace tests
{

    [TestFixture]
    public class Tests
    {

        [Test]
        public void ParseSimpleLine()
        {
            var codeReader = new CodeReader();
            codeReader.ParseCode("one two   three").ShouldBe(new[] { "one", "two", "three" });
        }

        [Test]
        public void ParseSeveralLines()
        {
            var codeReader = new CodeReader();
            codeReader.ParseCode("one  two \n three").ShouldBe(new[] { "one", "two", "three" });
        }
    }
}
