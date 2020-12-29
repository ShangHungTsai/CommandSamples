using FakeDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CheckResult> results = new List<CheckResult>();
            Invoker invoker = Client.CreateInvoker();

            foreach (var item in FakeDataSource.Data)
            {
                results.Add(invoker.Action(item));
            }

            foreach (var item in results)
            {
                Console.WriteLine($"Source : {item.Source } , Result ={item.Result}");
            }
            Console.ReadLine();
        }
    }
}
