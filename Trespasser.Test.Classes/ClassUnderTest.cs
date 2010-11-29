namespace Trespasser.Test.Classes
{
    public class ClassUnderTest
    {
        private int _privateField;
        private int PrivateProperty { get; set; }
        private void PrivateMethod()
        {
            
        }

        private int BadlyNamedField;
        private int badlyNamedProperty { get; set; }

        private static int _staticField;
        private static int StaticProperty { get; set; }
        private static void StaticMethod()
        {

        }

        protected int ProtectedField;
        protected int ProtectedProperty { get; set; }
        protected void ProtectedMethod()
        {

        }

        internal int InternalField;
        internal int InternalProperty { get; set; }
        internal void InternalMethod()
        {

        }
    }
}
