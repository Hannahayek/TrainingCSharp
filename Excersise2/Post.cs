using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise2
{
    public class Post
    {

    
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
    public int Votes { get; private set; }

    public Post()
    {
        Votes = 0;
    }

    public void UpVote()
    {
        Votes += 1;
    }

    public void DownVote()
    {
        Votes -= 1;
    }
}
}
