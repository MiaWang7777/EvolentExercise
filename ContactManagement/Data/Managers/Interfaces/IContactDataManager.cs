using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Managers.Interfaces
{
    public interface IContactDataManager
    {
        IEnumerable<Contact> GetAllContacts();
        Contact GetContactById(int id);
        int InsertUpdateContact(Contact contact);
        bool DeleteContact(int id);
    }
}
