
using KabogluTeknik.Context;
using KabogluTeknik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KabogluTeknik.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly GeneralContext _context;

        public AboutService(GeneralContext context)
        {
            _context = context;
        }

        public async Task CreateAboutAsync(About about)
        {
            await _context.abouts.AddAsync(about);
            await _context.SaveChangesAsync();
        }

        public async Task<About> GetAboutAsync()
        {
            return await _context.abouts.FirstOrDefaultAsync();
        }

        public async Task UpdateAboutAsync(About about)
        {
            _context.abouts.Update(about);
            await _context.SaveChangesAsync();
        }
    }
}
