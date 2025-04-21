using KabogluTeknik.Context;
using KabogluTeknik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KabogluTeknik.Services.GeneralServices
{
    public class GeneralService : IGeneralService
    {
        private readonly GeneralContext _context;

        public GeneralService(GeneralContext context)
        {
            _context = context;
        }

        public async Task CreateGeneralAsync(General General)
        {
            await _context.generals.AddAsync(General);
            await _context.SaveChangesAsync();
        }

        public Task<General> GetGeneralAsync()
        {
            return _context.generals.FirstOrDefaultAsync();
        }

        public async Task UpdateGeneralAsync(General General)
        {
            _context.generals.Update(General);
            await _context.SaveChangesAsync();
        }
    }
}
