using KabogluTeknik.Context;
using KabogluTeknik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KabogluTeknik.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly GeneralContext _context;

        public ContactService(GeneralContext context)
        {
            _context = context;
        }

        public async Task CreateContactAsync(Contact contact)
        {
            await _context.contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }

        public Task<Contact> GetContactAsync()
        {
            return _context.contacts.FirstOrDefaultAsync();
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            _context.contacts.Update(contact);
            await _context.SaveChangesAsync();
        }
    }
}
