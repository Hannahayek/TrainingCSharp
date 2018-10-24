using System.Collections.Generic;
using System.Threading;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary=new Dictionary<string, string>();
        }

        //we declare an indexer
        public string this[string key]
        {
            get { return _dictionary[key];}
            set { _dictionary[key] = value; }
        }

    }
}