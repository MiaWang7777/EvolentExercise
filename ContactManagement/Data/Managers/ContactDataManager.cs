using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Managers;
using Data.Managers.Interfaces;

namespace Data.Managers
{
    public class ContactDataManager : IContactDataManager
    {
        private readonly ContactContext _db;
        public ContactDataManager(ContactContext db)
        {
            _db = db;
        }

        
        public IEnumerable<Contact> GetAllContacts()
        {
            return _db.Contacts.Where(x=>x.Status).ToList();
        }

        public Contact GetContactById( int id)
        {
            //only retrieve active record
            return _db.Contacts.FirstOrDefault(x => x.Id == id);
        } 


        public int InsertUpdateContact(Contact contact)
        {
            //Check ID, if 0 then insert new contact, else update contact
            if (contact.Id == 0)
            {
                var result = _db.Contacts.Add(contact);
                _db.SaveChanges();
                return result.Id;
            }
            else
            {
                var contactToUpdate = _db.Contacts.FirstOrDefault(x => x.Id == contact.Id && x.Status);
                if (contactToUpdate != null)
                {
                    contactToUpdate.FirstName = contact.FirstName;
                    contactToUpdate.LastName = contact.LastName;
                    contactToUpdate.Email = contact.Email;
                    contactToUpdate.Phone = contact.Phone;
                    _db.SaveChanges();
                    return contact.Id;
                }
                //if return 0, no active record found.
                return 0;
               
            }
        }

        public bool DeleteContact(int id)
        {
            var contact = _db.Contacts.FirstOrDefault(x => x.Id == id);
            if(contact!=null)
            {
                //flip status to inactive
                contact.Status = false;
                _db.SaveChanges();
                return true;
            }
            //no valid record found
            return false;
        }
    }
}
