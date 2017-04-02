using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Managers.Interfaces;
using Data.Managers.Interfaces;
using AutoMapper;
using Business.Entities;

namespace Business.Managers
{
    public class ContactBusinessManager :IContactBusinessManager
    {
        private readonly IContactDataManager _dataManager;
        public ContactBusinessManager(IContactDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return Mapper.Map<IEnumerable<Contact>>(_dataManager.GetAllContacts());
        }

        public Contact GetContactById(int id)
        {
            return Mapper.Map<Contact>(_dataManager.GetContactById(id));
        }

        public int InsertUpdateContact(Contact contact)
        {
            var contactMapped = Mapper.Map<Data.Entities.Contact>(contact);
            return _dataManager.InsertUpdateContact(contactMapped);
        }

        public bool DeleteContact(int id)
        {
            return _dataManager.DeleteContact(id);
        }
    }
}
