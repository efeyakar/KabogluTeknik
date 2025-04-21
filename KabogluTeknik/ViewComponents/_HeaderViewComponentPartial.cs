using KabogluTeknik.Services.HeaderServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.ViewComponents
{
    public class _HeaderViewComponentPartial : ViewComponent
    {
        private readonly IHeaderService _headerService;

        public _HeaderViewComponentPartial(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _headerService.GetHeaderAsync();
            return View(values);
        }
    }
}
