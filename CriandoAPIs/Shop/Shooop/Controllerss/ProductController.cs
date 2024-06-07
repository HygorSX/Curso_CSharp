using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shooop.Data;
using Shooop.Models;


namespace Shooop.Controllerss
{
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get(
        [FromServices] DataContext context
        )
        {
            var products = await context
                .Products
                .Include(x => x.Category)
                .AsNoTracking()
                .ToListAsync();

            return products;
        }
    }
}
