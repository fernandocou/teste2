using NUnit.Framework;
using aulapro;
namespace aulapro.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ClasseFazAlgo Cfa = new ClasseFazAlgo();

            Assert.AreEqual(true, Cfa.FazAlgo());
            Assert.Pass();
        }
    }
}