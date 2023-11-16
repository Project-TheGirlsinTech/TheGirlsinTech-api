using Microsoft.AspNetCore.Mvc;
using TheGirlsinTech.Domain.Catalog;

namespace TheGirlsinTech.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };

            return Ok(items);
        }
        
        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new item("Shirt", "Ohio State shirt", "Nike", 29.99m);
            item.Id = id;
            
            return Ok(item);
        }

        [HttpPost]
        publicIActionResult Post(Item item)
        {
            return Created("/catalog/42", item);
        }
    }
}