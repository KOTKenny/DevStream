using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Task3
{
    public static class InstancesHelper<T> where T : class
    {
        public static List<string> GetNamesOfInstances(IEnumerable<T> objects)
        {
            return objects.Select(x => x.GetType().Name).OrderBy(x => x).ToList();
        }

        public static Type GetTypeByNamePart(IEnumerable<T> objects, string name)
        {
            return objects.Where(x => x.GetType().Name.Contains(name)).SingleOrDefault().GetType();
        }

        public static void OutputInstancesToDisk(IEnumerable<T> objects)
        {
            using (FileStream fstream = new FileStream("output.txt", FileMode.OpenOrCreate))
            {
                foreach(T obj in objects)
                {
                    byte[] buffer = Encoding.Default.GetBytes(JsonSerializer.Serialize(obj));
                    fstream.Write(buffer);
                }
            }
        }
    }
}
