namespace KabogluTeknik.Areas.Admin.Models
{
    public class AboutViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
