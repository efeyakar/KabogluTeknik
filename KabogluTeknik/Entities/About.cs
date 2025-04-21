using System.ComponentModel.DataAnnotations.Schema;

namespace KabogluTeknik.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
