using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Task2
{
    public static class InstanceService<T> where T : new()
    {
        public static IEnumerable<T> GetInstances()
        {
            return Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)))
                .Select(t => (T)Activator.CreateInstance(t));

        }
    }
}
