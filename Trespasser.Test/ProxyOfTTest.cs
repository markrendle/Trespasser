using NUnit.Framework;
using Trespasser.Test.Classes;

namespace Trespasser.Test
{
    [TestFixture]
    public class ProxyOfTTest
    {
        [Test]
        public void TestPrivateStaticMethod()
        {
            var proxy = Proxy.Static<ClassUnderTest>();
            proxy.StaticMethod();
            Assert.Pass();
        }

        [Test]
        public void TestGetPrivateStaticProperty()
        {
            var proxy = Proxy.Static<ClassUnderTest>();
            int n = proxy.StaticProperty;
            Assert.Pass();
        }

        [Test]
        public void TestSetPrivateStaticProperty()
        {
            var proxy = Proxy.Static<ClassUnderTest>();
            proxy.StaticProperty = 1;
            Assert.AreEqual(1, proxy.StaticProperty);
        }

        [Test]
        public void TestGetPrivateField()
        {
            var proxy = Proxy.Static<ClassUnderTest>();
            int n = proxy._staticField;
            Assert.Pass();
        }

        [Test]
        public void TestSetPrivateField()
        {
            var proxy = Proxy.Static<ClassUnderTest>();
            proxy._staticField = 1;
            Assert.AreEqual(1, proxy._staticField);
        }
    }
}
