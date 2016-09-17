using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Net.Http;

namespace GitApi1._5
{
    class AsyncClass
    {
        public async Task GitApi()
        {
            await Task.Run(async () =>
            {
                await LongRunningOperation();
            });
        }
        private static async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 50000; counter++)
            {
                Console.WriteLine(counter);
            }
            return "counter = " + counter;
        }
            
            /*var owner = string.Empty;
            var reponame = string.Empty;

            owner = "jennnyf19";
            reponame = "BinaryTree";

            Console.WriteLine(owner + " " + reponame);

            GitHubClient client = new GitHubClient(new ProductHeaderValue("JennysAwesomeGitRelease"));

            Console.WriteLine(client);

            await Task.Run(async () =>
            {
                var repository = await client.Repository.Get(owner, reponame);


                Console.WriteLine(repository);

                Console.WriteLine(String.Format("binaryTree can be found at {0}\n", repository.HtmlUrl));

                Console.WriteLine("It currently has {0} watchers and {1} forks\n", repository.StargazersCount, repository.ForksCount);

                Console.WriteLine("It has {0} open issues\n", repository.OpenIssuesCount);

                Console.WriteLine("And GitHub thinks it is a {0} project", repository.Language);
            });*/


        }
    }
