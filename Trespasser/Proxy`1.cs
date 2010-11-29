using System.Reflection;

namespace Trespasser
{
    public class Proxy<T> : Proxy
    {
        internal Proxy() : base(typeof(T))
        {
        }

        protected override BindingFlags BindingFlags
        {
            get
            {
                return BindingFlags.Static | BindingFlags.NonPublic;
            }
        }
    }
}
