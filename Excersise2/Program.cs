using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise2
{
    class Program
    {
        static void Main(string[] args)
        {

            var myPost = new Post();

            Console.WriteLine(myPost.Votes);

            myPost.UpVote();
            myPost.UpVote();
            myPost.UpVote();
            myPost.UpVote();

            Console.WriteLine(myPost.Votes);

            myPost.DownVote();
            myPost.DownVote();
            myPost.DownVote();
            Console.WriteLine(myPost.Votes);
            Console.ReadLine();
        }
    }
}
