using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Services
{
    public class CustomerService
    {
        public List<Customer> retrieveAll()
        {
            List<Customer> result;
            using (CustomerModel context = new CustomerModel())
            {

                var res = context.TBL_CUSTOMERS.Select(c => new Customer
                {
                    Id = c.ID,
                    Name = c.NAME,
                    LastName = c.LAST_NAME,
                    DateOfBirth = c.DATE_OF_BIRTH,
                    Sex = c.SEX,
                    State = c.STATE
                });
                result = res.ToList();
            }

            return result;

        }

        public void Create(Customer customer)
        {
            using (CustomerModel context = new CustomerModel())
            {


                TBL_CUSTOMERS newCustomer = new TBL_CUSTOMERS
                {
                    ID = customer.Id,
                    NAME = customer.Name,
                    LAST_NAME = customer.LastName,
                    DATE_OF_BIRTH = customer.DateOfBirth,
                    SEX = customer.Sex,
                    STATE = customer.State
                };

                context.TBL_CUSTOMERS.Add(newCustomer);
                context.SaveChanges();
            }

         
        }

        public void Update(Customer customer)
        {
            using (CustomerModel context = new CustomerModel())
            {
                var result = context.TBL_CUSTOMERS.SingleOrDefault(c => c.ID == customer.Id);
                if (result != null)
                {

                    result.NAME = customer.Name;
                    result.LAST_NAME = customer.LastName;
                    result.DATE_OF_BIRTH = customer.DateOfBirth;
                    result.SEX = customer.Sex;
                    result.STATE = customer.State;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Customer customer)
        {
            using (CustomerModel context = new CustomerModel())
            {
                var result = context.TBL_CUSTOMERS.SingleOrDefault(c => c.ID == customer.Id);
                if (result != null)
                {
                    context.TBL_CUSTOMERS.Remove(result);
                    context.SaveChanges();
                }


            }

        }
            
    }
}
