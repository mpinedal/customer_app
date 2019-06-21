using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class ContactMethod: BaseEntity
    {

        public string Type { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string INDPublicidad { get; set; }
        public string OwnerId { get; set; }


        public ContactMethod()
        {

        }

        public ContactMethod(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 5)
            {
                Type = infoArray[0];
                Value = infoArray[1];
                Description = infoArray[2];
                INDPublicidad = infoArray[3];
                OwnerId = infoArray[4];





            }
            else
            {
                throw new Exception("All values are required");
            }

        }




    }
}
