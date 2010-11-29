using System;
using System.Dynamic;
using System.Reflection;

namespace Trespasser
{
    public class Proxy : DynamicObject
    {
        private readonly Type _type;
        private readonly object _target;

        private Proxy(object target)
        {
            _target = target;
            _type = target.GetType();
        }

        protected Proxy(Type type)
        {
            _type = type;
        }

        public static dynamic Create(object target)
        {
            return new Proxy(target);
        }

        public static dynamic Static<T>()
        {
            return new Proxy<T>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            MethodInfo method;
            if (TryGetMethodInfo(binder.Name, out method))
            {
                result = method.Invoke(_target, args);
                return true;
            }

            result = null;
            return false;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (char.IsUpper(binder.Name, 0))
            {
                return TryGetProperty(binder.Name, out result) || TryGetField(binder.Name, out result);
            }
            return TryGetField(binder.Name, out result) || TryGetProperty(binder.Name, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (char.IsUpper(binder.Name, 0))
            {
                return TrySetProperty(binder.Name, value) || TrySetField(binder.Name, value);
            }
            return TrySetField(binder.Name, value) || TrySetProperty(binder.Name, value);
        }

        private bool TrySetProperty(string name, object value)
        {
            PropertyInfo property;
            if (TryGetPropertyInfo(name, out property))
            {
                property.SetValue(_target, value, null);
                return true;
            }
            return false;
        }

        private bool TryGetProperty(string name, out object result)
        {
            PropertyInfo property;
            if (TryGetPropertyInfo(name, out property))
            {
                result = property.GetValue(_target, null);
                return true;
            }
            result = null;
            return false;
        }

        private bool TryGetField(string name, out object result)
        {
            FieldInfo field;
            if (TryGetFieldInfo(name, out field))
            {
                result = field.GetValue(_target);
                return true;
            }
            result = null;
            return false;
        }

        private bool TrySetField(string name, object value)
        {
            FieldInfo field;
            if (TryGetFieldInfo(name, out field))
            {
                field.SetValue(_target, value);
                return true;
            }
            return false;
        }

        protected bool TryGetMethodInfo(string name, out MethodInfo methodInfo)
        {
            methodInfo = _type.GetMethod(name, BindingFlags);
            return methodInfo != null;
        }

        protected bool TryGetPropertyInfo(string name, out PropertyInfo propertyInfo)
        {
            propertyInfo = _type.GetProperty(name, BindingFlags);
            return propertyInfo != null;
        }

        protected bool TryGetFieldInfo(string name, out FieldInfo fieldInfo)
        {
            fieldInfo = _type.GetField(name, BindingFlags);
            return fieldInfo != null;
        }

        protected virtual BindingFlags BindingFlags
        {
            get
            {
                return BindingFlags.Instance | BindingFlags.NonPublic;
            }
        }
    }
}
