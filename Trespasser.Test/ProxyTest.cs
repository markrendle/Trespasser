using NUnit.Framework;
using Trespasser.Test.Classes;

namespace Trespasser.Test
{
    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void TestPrivateInstanceMethod()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.PrivateMethod();
            Assert.Pass();
        }

        [Test]
        public void TestGetPrivateProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.PrivateProperty;
            Assert.Pass();
        }

        [Test]
        public void TestSetPrivateProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.PrivateProperty = 1;
            Assert.AreEqual(1, proxy.PrivateProperty);
        }

        [Test]
        public void TestGetBadlyNamedProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.badlyNamedProperty;
            Assert.Pass();
        }

        [Test]
        public void TestSetBadlyNamedProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.badlyNamedProperty = 1;
            Assert.AreEqual(1, proxy.badlyNamedProperty);
        }

        [Test]
        public void TestGetPrivateField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy._privateField;
            Assert.Pass();
        }

        [Test]
        public void TestSetPrivateField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy._privateField = 1;
            Assert.AreEqual(1, proxy._privateField);
        }

        [Test]
        public void TestGetBadlyNamedField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.BadlyNamedField;
            Assert.Pass();
        }

        [Test]
        public void TestSetBadlyNamedField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.BadlyNamedField = 1;
            Assert.AreEqual(1, proxy.BadlyNamedField);
        }

        [Test]
        public void TestProtectedInstanceMethod()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.ProtectedMethod();
            Assert.Pass();
        }

        [Test]
        public void TestGetProtectedProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.ProtectedProperty;
            Assert.Pass();
        }

        [Test]
        public void TestSetProtectedProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.ProtectedProperty = 1;
            Assert.AreEqual(1, proxy.ProtectedProperty);
        }

        [Test]
        public void TestGetProtectedField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.ProtectedField;
            Assert.Pass();
        }

        [Test]
        public void TestSetProtectedField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.ProtectedField = 1;
            Assert.AreEqual(1, proxy.ProtectedField);
        }

        [Test]
        public void TestInternalInstanceMethod()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.InternalMethod();
            Assert.Pass();
        }

        [Test]
        public void TestGetInternalProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.InternalProperty;
            Assert.Pass();
        }

        [Test]
        public void TestSetInternalProperty()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.InternalProperty = 1;
            Assert.AreEqual(1, proxy.InternalProperty);
        }

        [Test]
        public void TestGetInternalField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            int n = proxy.InternalField;
            Assert.Pass();
        }

        [Test]
        public void TestSetInternalField()
        {
            var proxy = Proxy.Create(new ClassUnderTest());
            proxy.InternalField = 1;
            Assert.AreEqual(1, proxy.InternalField);
        }
    }
}
