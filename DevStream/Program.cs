using System;
using Task1;
using Task1.Interfaces;
using Task2;
using Task3;
using Task4;

namespace DevStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task3

            var t = InstanceService<Vehicle>.GetInstances();

            var names = InstancesHelper<Vehicle>.GetNamesOfInstances(t);

            Console.WriteLine(String.Join(", ", names));

            var t1 = InstancesHelper<Vehicle>.GetTypeByNamePart(t, "Bu");

            InstancesHelper<Vehicle>.OutputInstancesToDisk(t);

            var missElems1 = ArrayHelper.MissingElements(new[] { 4, 6, 9 });
            var missElems2 = ArrayHelper.MissingElements(new[] { 2, 3, 4 });
            var missElems3 = ArrayHelper.MissingElements(new[] { 1, 3, 4 });
        }
    }
}
