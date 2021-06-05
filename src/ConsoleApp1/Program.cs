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
            Func<int, int> plus(int x) => y => x + y;

            var ret = await Task.FromResult(1).Select(plus(2));

            Console.WriteLine(ret);
        }
    }
}
