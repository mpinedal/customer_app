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

        public void Create(Direction direction)
        {
            using (CustomerModel context = new CustomerModel())
            {


                TBL_DIRECTIONS newDirection = new TBL_DIRECTIONS
                {
                    PROVINCE = direction.Province,
                    CANTON = direction.Canton,
                    DISTRITO = direction.Distrito,
                    DETAILS = direction.Details,
                    TYPE = direction.Type,
                    OWNER_ID = direction.OwnerId
                };

                context.TBL_DIRECTIONS.Add(newDirection);
                context.SaveChanges();
            }


        }

        public void Update(Direction direction)
        {
            using (CustomerModel context = new CustomerModel())
            {
                var result = context.TBL_DIRECTIONS.SingleOrDefault(d => d.ID == direction.ID);
                if (result != null)
                {

                    result.PROVINCE = direction.Province;
                    result.CANTON = direction.Canton;
                    result.DISTRITO = direction.Distrito;
                    result.DETAILS = direction.Details;
                    result.TYPE = direction.Type;
                    result.OWNER_ID = direction.OwnerId;

                    context.SaveChanges();
                }
            }
        }


        public void Delete(Direction direction)
        {
            using (CustomerModel context = new CustomerModel())
            {
                var result = context.TBL_DIRECTIONS.SingleOrDefault(d => d.ID == direction.ID);
                if (result != null)
                {
                    context.TBL_DIRECTIONS.Remove(result);
                    context.SaveChanges();
                }


            }

        }

    }
}
