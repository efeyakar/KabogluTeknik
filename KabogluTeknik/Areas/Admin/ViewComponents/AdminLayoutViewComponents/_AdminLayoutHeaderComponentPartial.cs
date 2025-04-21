using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutHeaderComponentPartial : ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
