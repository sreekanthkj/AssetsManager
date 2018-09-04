using System;
using NUnit.Framework;
namespace Assets.Services.Tests
{
    [TestFixture]
    public class SampleTest
    {
        SampleClass obj;

        [SetUp]
        public void Test() // just to demonstrate set up runs before each method !
        {
            obj = new SampleClass();
        }

        [Test]
        public void SampleTestsAssetsTrue() // simple assert
        {
            Assert.That(obj.Add(1, 1), Is.EqualTo(2));
            Console.Write(string.Format("1+1 is equals to {0}", 2));
        }

        [TestCase(arg1: 1, arg2: 1, ExpectedResult = 2)]
        [TestCase(arg1: 10, arg2: 10, ExpectedResult = 20)]
        public int TestCaseExamples(int a, int b) // this method wil be executed twice because we have written 2 test cases
        {
            return obj.Add(a, b);
        }
    }

    public class SampleClass
    {
        public int Add(int a, int b) => a + b;
    }
}
