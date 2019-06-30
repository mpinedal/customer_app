using DataAccess.Crud;

using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi
{
    public class CustomerManagement : BaseManagement
    {

        private CustomerCrudFactory crudCustomer;

        public CustomerManagement()
        {
            crudCustomer = new CustomerCrudFactory();
        }

        public void Create(Customer customer)
        {
            try
            {
                var c = crudCustomer.Retrieve<Customer>(customer);
                if (c != null)
                    {
                    //Cutomer already exists
                    Console.WriteLine("Cutomer already exists");
                }

                if (customer.Sex.ToLower().Equals("m") || customer.Sex.ToLower().Equals("f"))
                {
                    crudCustomer.Create(customer);

                }
                else
                {
                    throw new BusinessException(4);
                }

            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }
            //crudCustomer.Create(customer);

        }


        public List<Customer> RetrieveAll()
        {
            return crudCustomer.RetrieveAll<Customer>();
        }

        public Customer RetrieveById(Customer customer)
        {
            return crudCustomer.Retrieve<Customer>(customer);
        }

        public void Update(Customer customer)
        {
            crudCustomer.Update(customer);
        }

        public void Delete(Customer customer)
        {
            crudCustomer.Delete(customer);
        }


    }
}
