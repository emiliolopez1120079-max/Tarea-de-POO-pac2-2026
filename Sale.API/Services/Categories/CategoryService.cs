using Sale.API.Dtos.Common;
using Sales. API.Entities;
namespace Sale.API.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        public Task<ResponseDto<CategoryEntity>> CreateAsync(CategoryEntity category)
        {
            throw new NotImplementedException();
        }
    }
}