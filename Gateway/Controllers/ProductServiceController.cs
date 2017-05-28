using Gateway.Models;
using Gateway.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gateway.Controllers
{
    public class ProductServiceController : ApiController
    {
        ProductServiceClient client = new ProductServiceClient();

        
        [Route("api/getAllProducts")]
        public IEnumerable<ProductServiceReference.Product> GetAllProducts()
        {
            return client.GetAllProducts();
        }

        [Route("api/DecreaseProductCount/{id}/{count}")]
        public bool DecreaseProductCount(int id, int count)
        {
            return client.DecreaseProductCount(id, count);
        }
    }
}
