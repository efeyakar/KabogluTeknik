
using KabogluTeknik.Context;
using KabogluTeknik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KabogluTeknik.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly GeneralContext _context;

        public CategoryService(GeneralContext context)
        {
            _context = context;
        }

        public async Task CreateCategoryAsync(Category Category)
        {
            await _context.categories.AddAsync(Category);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetCategoryAsync()
        {
            return await _context.categories.ToListAsync();
        }

        public async Task<Category> GetByIdCategoryAsync(int id)
        {
            return  await _context.categories.FindAsync(id);
        }

        public async Task UpdateCategoryAsync(Category Category)
        {
            _context.categories.Update(Category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id) 
        {
            var values = await _context.categories.FindAsync(id);
            _context.Remove(values);
            await _context.SaveChangesAsync();
        }

    }
}
