using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Email : BaseEntity
    {

        public string EmailAddress { get; set; }
        public string Owner { get; set; }
        public string Content { get; set; }


    }
}
