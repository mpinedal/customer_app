using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Customer : BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string State { get; set; }

        public Customer()
        {

        }

        public Customer(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 4)
            {
                Id = infoArray[0];
                Name = infoArray[1];
                LastName = infoArray[2];

                var date = default(DateTime);
                if (DateTime.TryParse(infoArray[3], out date))
                    DateOfBirth = date;
                else
                    throw new Exception("Must be a date");

                Sex = infoArray[4];
                State = infoArray[5];



            }
            else
            {
                throw new Exception("All values are required");
            }

        }

    }
}
