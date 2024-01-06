using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDirectory
{
    public class UserController
    {
        public Users GetAll()
        {
            return new ApiReader.Response("https://fakestoreapi.com").Get<Users>("users");
        }
    }
}
