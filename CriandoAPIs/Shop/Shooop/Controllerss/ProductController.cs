﻿using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
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

        [HttpGet]
        [Route("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<Product>> GetById(
            [FromServices] DataContext context,
            int id
            )
        {
            var product = await context
                .Products
                .Include(x => x.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return product;
        }

        [HttpGet]
        [Route("categories/{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Product>>> GetByCategory(
            [FromServices] DataContext context,
            int id
            )
        {
            var products = await context
                .Products
                .Include(x => x.Category)
                .AsNoTracking()
                .Where(x => x.CategoryId == id)
                .ToListAsync();

            return products;
        }

        [HttpPost]
        [Route("")]
        [Authorize(Roles = "employee")]
        public async Task<ActionResult<Product>> Post(
            [FromServices] DataContext context,
            [FromBody] Product model)
        {
            if (ModelState.IsValid)
            { 
                context.Products.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}

