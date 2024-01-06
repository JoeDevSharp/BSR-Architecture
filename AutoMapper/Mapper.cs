using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutoMapper
{
    public static class Mapper
    {
        public static To Convert<From, To>(From obj)
        {
            return JsonSerializer.Deserialize<To>(JsonSerializer.Serialize(obj));
        }
    }
}
