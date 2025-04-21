using KabogluTeknik.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.Areas.Admin.ViewComponents.CategoryViewComponents
{
    public class _CategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CategoryListComponentPartial(ICategoryService categoryService)
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
