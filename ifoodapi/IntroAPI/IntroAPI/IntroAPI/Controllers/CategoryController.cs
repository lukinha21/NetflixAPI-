using IntroAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroAPI.Controllers
{

    [Route("/merchants/{merchantId}/product")]
    [ApiController]
    public class CategoryController:ControllerBase
    {

        /// <summary>
        /// List all categories within a specific catalog, which may include items within those categories
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/catalogs/{catalogId}/categories")]
        public IActionResult List_categories(string merchantId, [FromQuery]ItemsViewModel itemsV)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Create a category within a catalog
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogId">Catalog UUID</param>

        /// <returns></returns>
        [HttpPost("/merchants/{merchantId}/catalogs/{catalogId}/categories")]
        public IActionResult Create_category(string merchantId,string catalogId)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Fetch a specific category, which may include items within that category
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogId">Catalog UUID</param>
        /// <param name="categoryId">Category UUID</param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/catalogs/{catalogId}/categories/{categoryId}")]
        public IActionResult Get_a_category(string merchantId,string catalogId, string categoryId, [FromQuery]ItemsViewModel itemsV)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Edit a category. Unsent fields will preserve their former values. Status changes may be applied to the items associated with the given category.
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogId">Catalog UUID</param>
        /// <param name="categoryId">Category UUID</param>
        /// <returns></returns>
        [HttpPatch("/merchants/{merchantId}/catalogs/{catalogId}/categories/{categoryId}")]
        public IActionResult Edit_a_category(string merchantId,string catalogId,string categoryId)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// List all items within that category
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="categoryId">Category UUID</param>

        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/categories/{categoryId}/Items")]
        public IActionResult List_items_with_that_category(string merchantId,string categoryId)
        {
            return Ok("Ok");
        }
        /// <summary>
        /// Delete a category in all merchant services. All items within that category will also be deleted
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="categoryId">Category UUID</param>
        /// <returns></returns>
        [HttpDelete("/merchants/{merchantId}/categories/{categoryId}")]
        public IActionResult Delete_a_category(string merchantId,string categoryId)
        {
            return Ok("Ok");
        }


    }
}
