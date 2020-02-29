using NUnit.Framework;
using System;
using System.IO;

namespace Tests
{
    public class Tests
    {
        private const string Expected = "John";

        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                SoftQualAndTestingAssignment1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}