using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Net;
using Octokit.Reactive;
using System.Net.Http;

namespace GitApi1._5
{
    class Program
    {
        static void Main()
        {
            var demo = new AsyncClass();
            demo.GitApi();

            while (true)
            {
                Console.WriteLine("doing stuff on the main thread...........................");
            }
            Console.ReadLine();
        }

    }

}
