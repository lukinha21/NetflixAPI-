using IntroAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IfoodAPI.Controllers
{
    [Route("/merchants/{merchantId}/catalogs")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        /// <summary>
        /// List all available catalogs given a Merchant Id
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListCatalogs(string merchantId)
        {
            return Ok("Ok");
        }

        /// <summary>
        /// List all changes made to a catalog given a time window These changes are currently indexed at category level, which means, in case something is changed within a category, there will be a registry indicating something has changed. There will be two fields in the response body: modifiedAt (date and time which a change has been made) and changelogIngestedAt (date and time which a change has been processed by Changelog system). Registries will be queried based on changelogIngestedAt from newest to oldest
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogId">Catalog UUID</param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/catalogs/{catalogId}/changelog")]
        public IActionResult ListChangelogs(string merchantId, string catalogId, [FromQuery]DateViewModel Date)
        {
            return Ok("Ok");
        }

        /// <summary>
        /// List all unsellable categories or categories containing unsellable items. That is, categories or items with violations, paused ones, etc.
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="catalogId">Catalog UUID</param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/catalogs/{catalogId}/unsellableItems")]
        public IActionResult ListUnsellableItems(string merchantId, string catalogId)
        {
            return Ok("Ok");
        }

        /// <summary>
        /// List all sellable items, it will return only items that can be sold using all attributes and schedule information.
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <param name="groupId">Group UUID</param>
        /// <returns>.</returns>
        [HttpGet("/merchants/{merchantId}/catalogs/{groupId}/sellableItems")]
        public IActionResult ListSellableItems(string merchantId, string groupId)
        {
            // Lógica para listar itens vendáveis
            return Ok("Ok");
        }

        /// <summary>
        /// Returns the version of the catalog, which implies the version of the API this store should use.
        /// </summary>
        /// <param name="merchantId">Merchant UUID</param>
        /// <returns></returns>
        [HttpGet("/merchants/{merchantId}/catalogs/version")]
        public IActionResult CheckVersion(string merchantId)
        {
            // Lógica para checar versão
            return Ok("Ok");
        }
    }
}
