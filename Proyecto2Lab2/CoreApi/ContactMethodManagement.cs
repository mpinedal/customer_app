using DataAccess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi
{
    public class ContactMethodManagement : BaseManagement
    {

        private ContactMehodCrudFactory crudContactMehod;

        public ContactMethodManagement()
        {
            crudContactMehod = new ContactMehodCrudFactory();

        }

        public void Create(ContactMethod contactMethod)
        {
            crudContactMehod.Create(contactMethod);
        }

        public List<ContactMethod> RetrieveAll()
        {
            return crudContactMehod.RetrieveAll<ContactMethod>();
        }

        public ContactMethod RetrieveById(ContactMethod contactMethod)
        {
            return crudContactMehod.Retrieve<ContactMethod>(contactMethod);
        }

        public void Update (ContactMethod contactMethod)
        {
            crudContactMehod.Update(contactMethod);
        }

        public void Delete (ContactMethod contactMethod)
        {
            crudContactMehod.Delete(contactMethod);
        }



    }
}
