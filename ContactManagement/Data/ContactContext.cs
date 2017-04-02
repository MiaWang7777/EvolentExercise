namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Entities;

    public class ContactContext : DbContext
    {
        public ContactContext()
            : base("name=ContactContext")
        {
            //Database.SetInitializer<ContactContext>(null);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Contact> Contacts { get; set; }
    }

}