using DataAcess.Dao;
using DataAcess.Mapper;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAccess.Mapper
{
    class DirectionMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_PROVINCE = "PROVINCE";
        private const string DB_COL_CANTON = "CANTON";
        private const string DB_COL_DISTRITO = "DISTRITO";
        private const string DB_COL_DETAILS = "DETAILS";
        private const string DB_COL_TYPE = "TYPE";
        private const string DB_COL_OWNER_ID = "OWNER_ID";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_DIRECTION_PR" };

            var d = (Direction)entity;
           
            operation.AddVarcharParam(DB_COL_PROVINCE, d.Province);
            operation.AddVarcharParam(DB_COL_CANTON, d.Canton);
            operation.AddVarcharParam(DB_COL_DISTRITO, d.Distrito);
            operation.AddVarcharParam(DB_COL_DETAILS, d.Details);
            operation.AddVarcharParam(DB_COL_TYPE, d.Type);
            operation.AddVarcharParam(DB_COL_OWNER_ID, d.OwnerId);


            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_DIRECTION_PR" };

            var d = (Direction)entity;
            operation.AddVarcharParam(DB_COL_OWNER_ID, d.OwnerId);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_DIRECTIONS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_DIRECTION_PR" };

            var d = (Direction)entity;
            operation.AddVarcharParam(DB_COL_PROVINCE, d.Province);
            operation.AddVarcharParam(DB_COL_CANTON, d.Canton);
            operation.AddVarcharParam(DB_COL_DISTRITO, d.Distrito);
            operation.AddVarcharParam(DB_COL_DETAILS, d.Details);
            operation.AddVarcharParam(DB_COL_TYPE, d.Type);
            operation.AddVarcharParam(DB_COL_OWNER_ID, d.OwnerId);

            return operation;
        }


        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_DIRECTION_PR" };

            var d = (Direction)entity;
            operation.AddVarcharParam(DB_COL_OWNER_ID, d.OwnerId);
            return operation;
        }


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var direction = BuildObject(row);
                lstResults.Add(direction);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var direction = new Direction
            {
                Province = GetStringValue(row, DB_COL_PROVINCE),
                Canton = GetStringValue(row, DB_COL_CANTON),
                Distrito = GetStringValue(row, DB_COL_DISTRITO),
                Details = GetStringValue(row, DB_COL_DETAILS),
                Type = GetStringValue(row, DB_COL_TYPE),
                OwnerId = GetStringValue(row, DB_COL_OWNER_ID)

           

    };

            return direction;
        }

    }
}
