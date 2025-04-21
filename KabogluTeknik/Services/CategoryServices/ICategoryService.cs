using KabogluTeknik.Entities;

namespace KabogluTeknik.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoryAsync();
        Task UpdateCategoryAsync(Category Category);
        Task CreateCategoryAsync(Category Category);
        Task DeleteCategoryAsync(int id);
        Task<Category> GetByIdCategoryAsync(int id);
    }
}
