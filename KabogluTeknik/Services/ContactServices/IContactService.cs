using KabogluTeknik.Entities;

namespace KabogluTeknik.Services.ContactServices
{
    public interface IContactService
    {
        Task<Contact> GetContactAsync();
        Task UpdateContactAsync(Contact contact);
        Task CreateContactAsync(Contact contact);
    }
}
