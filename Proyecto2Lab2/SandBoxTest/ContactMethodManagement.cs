using DataAccess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class ContactMethodManagement
    {

        private ContactMehodCrudFactory crudContactMethod;

        public ContactMethodManagement()
        {
            crudContactMethod = new ContactMehodCrudFactory();
        }

        public void Create(ContactMethod contactMenthod)
        {

            crudContactMethod.Create(contactMenthod);

        }


        public List<ContactMethod> RetrieveAll()
        {
            return crudContactMethod.RetrieveAll<ContactMethod>();
        }

        public ContactMethod RetrieveById(ContactMethod contactMethod)
        {
            return crudContactMethod.Retrieve<ContactMethod>(contactMethod);
        }

        internal void Update(ContactMethod contactMethod)
        {
            crudContactMethod.Update(contactMethod);
        }

        internal void Delete(ContactMethod contactMethod)
        {
            crudContactMethod.Delete(contactMethod);
        }
    }

}

