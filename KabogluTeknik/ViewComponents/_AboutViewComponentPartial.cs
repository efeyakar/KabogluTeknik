using KabogluTeknik.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.ViewComponents
{
    public class _AboutViewComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutViewComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAboutAsync();
            return View(values);
        }
    }
}
