using StoreRemoteService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRemoteService.Controllers
{
    public class ProductsController
    {
        private string Host = "https://fakestoreapi.com";

        public Products GetAll()
        {
            string path = "products";
            return new ApiReader.Response(Host).Get<Products>(path);
        }
    }
}
