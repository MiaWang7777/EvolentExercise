using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Managers.Interfaces
{
    public interface IContactBusinessManager
    {
        IEnumerable<Contact> GetAllContacts();
        Contact GetContactById(int id);
        int InsertUpdateContact(Contact contact);
        bool DeleteContact(int id);
    }
}
