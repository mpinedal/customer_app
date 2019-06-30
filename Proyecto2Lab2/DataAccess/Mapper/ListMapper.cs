using DataAccess.Dao;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    class ListMapper: EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_ID = "ID";
        private const string DB_COL_DESCRIPTION = "DESCRIPTION";
        private const string DB_COL_VALUE= "VALUE";

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_LISTS_PR" };
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var optionList = BuildObject(row);
                lstResults.Add(optionList);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var optionList = new OptionList
            {
                ID = GetStringValue(row, DB_COL_ID),
                Description = GetStringValue(row, DB_COL_DESCRIPTION),
                Value = GetStringValue(row, DB_COL_VALUE)
                
                
            };

            return optionList;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }



        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
