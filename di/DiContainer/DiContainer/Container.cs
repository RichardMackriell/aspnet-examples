using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer
{
    internal class Container
    {
        private static Dictionary<Type, Type> _types = new Dictionary<Type, Type>();

        public static void Register<Interface, Class>()
        {
            _types.Add(typeof(Interface), typeof(Class));
        }
        private static object GetInstance(Type t)
        {
            return Activator.CreateInstance(_types[t]);
        }

        public static T GetInstance<T>()
        {
            Type t = typeof(T);
            var requiredParams = t.GetConstructors()[0].GetParameters();
            
            List<object> constructorObjects = new List<object>();

            foreach(var p in requiredParams)
            {
                constructorObjects.Add(GetInstance(p.ParameterType));
            }

            return (T)Activator.CreateInstance(_types[typeof(T)], constructorObjects.ToArray());
        }

    }
}
