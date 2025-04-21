using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.ViewComponents
{
    public class _ProjectViewComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
