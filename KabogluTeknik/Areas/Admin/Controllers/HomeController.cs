using KabogluTeknik.Entities;
using KabogluTeknik.Services.AboutServices;
using KabogluTeknik.Services.CategoryServices;
using KabogluTeknik.Services.ContactServices;
using KabogluTeknik.Services.GeneralServices;
using KabogluTeknik.Services.HeaderServices;
using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IGeneralService _generalService;
        private readonly IAboutService _aboutService;
        private readonly IContactService _contactService;
        private readonly IHeaderService _headerService;
        private readonly ICategoryService _categoryService;

        public HomeController(IGeneralService generalService, IAboutService aboutService, IContactService contactService, IHeaderService headerService, ICategoryService categoryService)
        {
            _generalService = generalService;
            _aboutService = aboutService;
            _contactService = contactService;
            _headerService = headerService;
            _categoryService = categoryService;
        }

        #region General
        [HttpGet]
        public async Task<IActionResult> General()
        {
            var values = await _generalService.GetGeneralAsync();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> General(General general)
        {
            if (general.Id == 0)
            {
                await _generalService.CreateGeneralAsync(general);
            }
            else
            {
                await _generalService.UpdateGeneralAsync(general);
            }
            return View();
        }
        #endregion

        #region Header
        [HttpGet]
        public async Task<IActionResult> Header()
        {
            var values = await _headerService.GetHeaderAsync();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Header(Header header)
        {
            if (header.Id == 0)
            {
                await _headerService.CreateHeaderAsync(header);
            }
            else
            {
                await _headerService.UpdateHeaderAsync(header);
            }
            return View();
        }
        #endregion

        #region About
        [HttpGet]
        public async Task<IActionResult> About()
        {
            var values = await _aboutService.GetAboutAsync();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> About(About about)
        {
            if (about.ImageFile != null && about.ImageFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                Directory.CreateDirectory(uploadsFolder); // Klasör yoksa oluştur

                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(about.ImageFile.FileName)}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await about.ImageFile.CopyToAsync(stream);
                }

                // Veritabanına kaydedilecek URL
                about.ImageUrl = $"/uploads/{fileName}";
            }

            if (about.Id == 0)
            {
                await _aboutService.CreateAboutAsync(about);
            }
            else
            {
                await _aboutService.UpdateAboutAsync(about);
            }

            return View(); // İşlem sonrası sayfayı yeniden yükler
        }

        #endregion

        #region Category
        public IActionResult Category()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Category(Category category)
        {
            // Yeni resim yüklendiyse dosyayı kaydet.
            if (category.ImageFile != null && category.ImageFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                Directory.CreateDirectory(uploadsFolder); // Klasör yoksa oluştur.

                // Dosya adını eşsiz hale getirmek için GUID kullanıyoruz.
                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(category.ImageFile.FileName)}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await category.ImageFile.CopyToAsync(stream);
                }

                // Resmin URL'sini belirliyoruz.
                category.ImageUrl = $"/uploads/{fileName}";
            }

            // Yeni kayıt mı yoksa güncelleme mi?
            if (category.Id == 0)
            {
                await _categoryService.CreateCategoryAsync(category);
            }
            else
            {
                await _categoryService.UpdateCategoryAsync(category);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("Category");
        }
        #endregion

        #region Product
        public IActionResult Product()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Product(Product product)
        {
            return View();
        }
        #endregion

        #region Project
        public IActionResult Project()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Project(Project project)
        {
            return View();
        }
        #endregion

        #region Contact
        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            var values = await _contactService.GetContactAsync();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Contact(Contact contact)
        {
            if (contact.Id == 0)
            {
                await _contactService.CreateContactAsync(contact);
            }
            else
            {
                await _contactService.UpdateContactAsync(contact);
            }
            return View();
        }
        #endregion
    }
}
