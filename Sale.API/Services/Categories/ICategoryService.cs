using Sale.API.Dtos.Common;
using Sales. API.Entities;
namespace Sale.API.Services.Categories
{
    public interface ICategoryService
    {
        Task<ResponseDto<CategoryEntity>> CreateAsync( CategoryEntity category);
    }
}