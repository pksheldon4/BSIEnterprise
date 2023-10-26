using Microsoft.AspNetCore.Mvc;

namespace CatalogService
{

	[ApiController]
    [Route("/api/catalog")]
    public class CatalogController
	{
		
		public CatalogController()
		{
		}

        [HttpGet(Name = "GetCatalog")]
        public string Get()
		{
			return "Welcome to Catalog";
		}

	}
}

