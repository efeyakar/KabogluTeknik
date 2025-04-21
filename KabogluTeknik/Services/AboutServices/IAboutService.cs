using KabogluTeknik.Entities;

namespace KabogluTeknik.Services.AboutServices
{
    public interface IAboutService
    {
        Task<About> GetAboutAsync();
        Task UpdateAboutAsync(About about);
        Task CreateAboutAsync(About about);
    }
}
