using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Services
{
   public class ContactMethodService
    {


        
            public List<ContactMethod> retrieveAll()
            {
                List<ContactMethod> result;
                using (CustomerModel context = new CustomerModel())
                {

                var res = context.TBL_CONTACTMETHODS.Select(c => new ContactMethod
                {
                    OwnerId = c.OWNER_ID,
                    Type = c.TYPE,
                    Value = c.VALUE,
                    Description = c.DESCRIPTION,
                    INDPublicidad = c.INDPUBLICIDAD,
                        ID = c.ID
           
                   
                       
                      
                    });
                    result = res.ToList();
                }

                return result;

            }

        public void Create(ContactMethod contactMethod)
        {
            using (CustomerModel context = new CustomerModel())
            {


                TBL_CONTACTMETHODS newContactMethod = new TBL_CONTACTMETHODS
                {

                    OWNER_ID = contactMethod.OwnerId,
                TYPE = contactMethod.Type,
                VALUE = contactMethod.Value,
                DESCRIPTION = contactMethod.Description,
                INDPUBLICIDAD = contactMethod.INDPublicidad

                };

                context.TBL_CONTACTMETHODS.Add(newContactMethod);
                context.SaveChanges();
            }


        }

        public void Update(ContactMethod contactMethod)
        {
            using (CustomerModel context = new CustomerModel())
            {
                var result = context.TBL_CONTACTMETHODS.SingleOrDefault(c => c.ID == contactMethod.ID);
                if(result != null)
                {
                    result.OWNER_ID = contactMethod.OwnerId;
                    result.TYPE = contactMethod.Type;
                    result.VALUE = contactMethod.Value;
                    result.DESCRIPTION = contactMethod.Description;
                    result.INDPUBLICIDAD = contactMethod.INDPublicidad;

                }

                context.SaveChanges();

            }
        }

        public void Delete(ContactMethod contactMethod)
        {
            using (CustomerModel context = new CustomerModel())
            {
                var result = context.TBL_CONTACTMETHODS.SingleOrDefault(c => c.ID == contactMethod.ID);
                if (result != null)
                {
                    context.TBL_CONTACTMETHODS.Remove(result);
                    context.SaveChanges();

                }

               

            }
        }


    }
}
