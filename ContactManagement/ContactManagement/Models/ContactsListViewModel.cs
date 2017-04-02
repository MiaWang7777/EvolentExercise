using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagement.Models
{
    public class ContactsListViewModel
    {
        public IEnumerable<ContactViewModel> Contacts { get; set; }
    }
}