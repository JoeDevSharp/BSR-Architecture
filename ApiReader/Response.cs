using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiReader
{
    public class Response
    {
        private string Host;
        public Response(string host)
        {
            Host = host;
        }

        public TRetour Get<TRetour>(string path)
        {
            string jsonContentString = new WebClient().DownloadString($"{Host}/{path}");
            return JsonSerializer.Deserialize<TRetour>(jsonContentString);
        }
    }
}
