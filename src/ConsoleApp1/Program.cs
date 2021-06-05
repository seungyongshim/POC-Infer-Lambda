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
            var ret1 = Task.FromResult(1).SelectMany(x => Task.FromResult(x.ToString()));

            var ret2 = from x in Task.FromResult(1)
                       from y in Task.FromResult(2)
                       select x + y;

            var ret3 = from x in Task.FromResult(1)
                       from y in Plus1(x)
                       select y;

            var ret5 = DivideZero();

            Console.WriteLine(await ret1);
            Console.WriteLine(await ret2);
            Console.WriteLine(await ret3);

            try
            {
                Console.WriteLine(await ret5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static Task<string> Plus1(int x) => Task.FromResult((x + 1).ToString());

        private static Task<double> DivideZero() => Task.FromResult(DividZero());

        private static double DividZero() => throw new NotImplementedException();
    }
}
