using System;
using System.Linq;
using System.Threading.Tasks;
using LanguageExt;

namespace ConsoleApp1
{
    internal class Program
    {
        private static async Task Main()
        {
            var ret = await Task.FromResult(1).SelectMany(x => Task.FromResult(x.ToString()));

            Console.WriteLine(ret);
        }
    }
}
