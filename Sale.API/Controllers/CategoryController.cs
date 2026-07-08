using Microsoft.AspNetCore.Mvc;
using Sales.API.Entities;
namespace Sales.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly List<CategoryEntity> _categories;

        public CategoryController()
        {
            _categories = new List<CategoryEntity>();
            _categories.Add(new CategoryEntity{Id = "1", Name = "Lácteos", Description = ""});
            _categories.Add(new CategoryEntity{Id = "2", Name = "Frutas", Description = ""});
            _categories.Add(new CategoryEntity{Id = "3", Name = "Higiene", Description = ""});
            _categories.Add(new CategoryEntity{Id = "4", Name = "Carnes", Description = ""});
            // _categories.Add("Lácteos");
            // _categories.Add("Carnes");
            // _categories.Add("Verduras");
            // _categories.Add("Frutas");
            // _categories.Add("Higiene");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        [HttpGet("{id}")] // GET: /categories/{id}
        public IActionResult GetOne(string id)
        {
            return Ok(_categories.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]CategoryEntity category)
        {
            _categories.Add(category);
            Console.WriteLine($"Categoría agregada: {category.Id}, {category.Name}, {category.Description}");
            return Ok("Categoría creada");
        }
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] CategoryEntity category)
        {
            category.Id = id;// se iguala para no mandarlo(????????(En la vida real no se hace)
            var oldCategory = _categories.FirstOrDefault(c => c.Id == id);
            if (oldCategory != null)
            {
                _categories.Remove(oldCategory);
                _categories.Add(category);
                Console.WriteLine($"Categoría actualizada: {category.Id}, {category.Name}, {category.Description}");
            }
            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(string id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if(category != null)
            {
                _categories.Remove(category);
                Console.WriteLine($"Categoría borrada: {category.Id}, {category.Name}, {category.Description}");

            }
            return Ok();
        }

    }
}