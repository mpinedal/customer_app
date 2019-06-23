using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Services
{
    public class DirectionService
    {

        public List<Direction> retrieveAll()
        {
            List<Direction> result;
            using (CustomerModel context = new CustomerModel())
            {

                var res = context.TBL_DIRECTIONS.Select(d => new Direction
                {
          
                    Province = d.PROVINCE,
                    Canton = d.CANTON,
                    Distrito = d.DISTRITO,
                    Details = d.DETAILS,
                    Type = d.TYPE,
                    OwnerId = d.OWNER_ID


                    });

                result = res.ToList();
            }

            return result;

        }

    }
}
