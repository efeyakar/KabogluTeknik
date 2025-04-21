using KabogluTeknik.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.ViewComponents
{
    public class _CategoryViewComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CategoryViewComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetCategoryAsync();
            return View(values);
        }
    }
}
