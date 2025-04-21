using KabogluTeknik.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.ViewComponents
{
    public class _ContactViewComponentPartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _ContactViewComponentPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _contactService.GetContactAsync();
            return View(values);
        }
    }
}
