using IntroAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;
namespace IntroAPI.Controllers
{
    [ApiController]
    [Route("/merchants/{merchantId}/products")]
    public class Productcontroller : ControllerBase
    {
        /// <summary>
        /// List all products registered to a given merchant
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListProducts(string merchantId,[FromQuery] ProductViewModel Pview)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Create a product. After being created, the product isn't yet available for sale. It is necessary to associate it to a category via item creation (association) API
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="ProdV">Represents the product to be created</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateProduct(string merchantId,ProdViewModel ProdV)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Edit a product. Once updated, all items and options associated to that product will also be updated
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="productId">Product UUID</param>
        /// <param name="ProdV">Value object representation of a product's fields to be updated</param>
        /// <returns></returns>
        [HttpPut("/merchants/{merchantId}/product/{productId}")]
        public IActionResult EditProduct(string merchantId,string productId,ProdViewModel ProdV)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Delete a product. All items and options associated to that product will also be deleted in all catalogs
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="productId">Product UUID</param>
        /// <returns></returns>
        [HttpDelete("/merchants/{merchantId}/product/{productId}")]
        public IActionResult DeleteProduct(string merchantId,string productId)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Batch update options and items statuses by productId or externalCode. All items and options associated to all given products will also be updated. It is also possible to define if only items or options should be update. This functionality is executed asynchronously. A batch id and an url are going to be returned. The url is from a get endpoint, where is possible to check each update result.
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogContext">The catalog context in which the operation is to be performed.</param>
        /// <returns></returns>
        [HttpPatch("/merchants/{merchantId}/products/status")]
        public IActionResult BatchUpdate_status(string merchantId, string catalogContext)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Batch update options and items prices by productId or externalCode. All items and options associated to all given products will also be updated. It is also possible to define if only items or options should be updated. This functionality is executed asynchronously. A batch id and an url are going to be returned. The url is from a get endpoint, where is possible to check each update result.
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogContext">The catalog context in which the operation is to be performed.</param>
        /// <returns></returns>
        [HttpPatch("/merchants/{merchantId}/products/price")]
        public IActionResult BatchUpdate_prices(string merchantId,string catalogContext=null)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// List all products registered to a given merchant by external code
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="externalCode"></param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/products/externalCode/{externalCode}")]
        public IActionResult ListProducts_external(string merchantId,string externalCode)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Get a product by id
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="productId">Product UUID</param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/product/{productId}")]
        public IActionResult Get_product_by_id(string merchantId,string productId)
        {
            return Ok("Ok");
        }

    }
}
