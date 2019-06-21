using DataAccess.Crud;

using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class DirectionManagement
    {

        private DirectionCrudFactory crudDirection;

        public DirectionManagement()
        {
            crudDirection = new DirectionCrudFactory();
        }

        public void Create(Direction direction)
        {

            crudDirection.Create(direction);

        }


        public List<Direction> RetrieveAll()
        {
            return crudDirection.RetrieveAll<Direction>();
        }

        public Direction RetrieveById(Direction direction)
        {
            return crudDirection.Retrieve<Direction>(direction);
        }

        internal void Update(Direction direction)
        {
            crudDirection.Update(direction);
        }

        internal void Delete(Direction direction)
        {
            crudDirection.Delete(direction);
        }

    }
}
