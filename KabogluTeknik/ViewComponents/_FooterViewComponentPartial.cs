using KabogluTeknik.Services.GeneralServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.ViewComponents
{
    public class _FooterViewComponentPartial : ViewComponent
    {
        private readonly IGeneralService _generalService;

        public _FooterViewComponentPartial(IGeneralService generalService)
        {
            _generalService = generalService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _generalService.GetGeneralAsync();
            return View(values);
        }
    }
}
