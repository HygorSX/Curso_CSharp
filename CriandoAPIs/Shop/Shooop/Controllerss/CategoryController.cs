using Microsoft.AspNetCore.Mvc;
using Shooop.Models;


// Endpoint => URL
// https://localhost:5001/categories

[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Get()
    {
        return new List<Category>();
    }


    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Category>> GetById(int id)
    {
        return new Category();
    }


    [HttpPost]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Post([FromBody] Category model)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(model);
    }


    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Category>>> Put(int id, [FromBody] Category model)
    {
        if (id != model.Id)
            return NotFound(new { message = "Categoria não encontrada" });

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok();
    }


    [HttpDelete]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Delete()
    {
        return Ok();
    }
}
