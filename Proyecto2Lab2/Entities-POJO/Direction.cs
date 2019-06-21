using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Direction : BaseEntity
    {

        public string Province { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Details { get; set; }
        public string Type { get; set; }
        public string OwnerId { get; set; }


        public Direction()
        {

        }

        public Direction(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 6)
            {
                Province = infoArray[0];
                Canton = infoArray[1];
                Distrito = infoArray[2];
                Details = infoArray[3];
                Type = infoArray[4];
                OwnerId = infoArray[5];



            }
            else
            {
                throw new Exception("All values are required");
            }

        }
    }
}
