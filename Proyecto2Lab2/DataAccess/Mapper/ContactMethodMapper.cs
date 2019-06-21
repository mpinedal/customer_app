using DataAcess.Dao;
using DataAcess.Mapper;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAccess.Mapper
{
    class ContactMethodMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_TYPE = "TYPE";
        private const string DB_COL_VALUE = "VALUE";
        private const string DB_COL_DESCRIPTION = "DESCRIPTION";
        private const string DB_COL_INDPUBLICIDAD = "INDPUBLICIDAD";
        private const string DB_COL_OWNER_ID = "OWNER_ID";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CONTACTMETHOD_PR" };

            var c = (ContactMethod)entity;


            operation.AddVarcharParam(DB_COL_TYPE, c.Type);
            operation.AddVarcharParam(DB_COL_VALUE, c.Value);
            operation.AddVarcharParam(DB_COL_DESCRIPTION, c.Description);
            operation.AddVarcharParam(DB_COL_INDPUBLICIDAD, c.INDPublicidad);
            operation.AddVarcharParam(DB_COL_OWNER_ID, c.OwnerId);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CONTACTMETHOD_PR" };

            var c = (ContactMethod)entity;
            operation.AddVarcharParam(DB_COL_OWNER_ID, c.OwnerId);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CONTACTMETHODS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CONTACTMETHOD_PR" };

            var c = (ContactMethod)entity;
            operation.AddVarcharParam(DB_COL_TYPE, c.Type);
            operation.AddVarcharParam(DB_COL_VALUE, c.Value);
            operation.AddVarcharParam(DB_COL_DESCRIPTION, c.Description);
            operation.AddVarcharParam(DB_COL_INDPUBLICIDAD, c.INDPublicidad);
            operation.AddVarcharParam(DB_COL_OWNER_ID, c.OwnerId);

            return operation;
        }



        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CONTACTMETHOD_PR" };

            var c = (ContactMethod)entity;
            operation.AddVarcharParam(DB_COL_OWNER_ID, c.OwnerId);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var contactMethod = BuildObject(row);
                lstResults.Add(contactMethod);
            }

            return lstResults;
        }


        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var contactMethod = new ContactMethod
            {
                Type = GetStringValue(row, DB_COL_TYPE),
                Value = GetStringValue(row, DB_COL_VALUE),
                Description = GetStringValue(row, DB_COL_DESCRIPTION),
                INDPublicidad = GetStringValue(row, DB_COL_INDPUBLICIDAD),
                OwnerId = GetStringValue(row, DB_COL_OWNER_ID)
    };

            return contactMethod;
        }


    }
}
