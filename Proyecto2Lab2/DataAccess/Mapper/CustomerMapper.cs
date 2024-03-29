﻿using DataAcess.Dao;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAcess.Mapper
{
    public class CustomerMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_LAST_NAME = "LAST_NAME";
        private const string DB_COL_DATE_OF_BIRTH = "DATE_OF_BIRTH";
        private const string DB_COL_SEX = "SEX";
        private const string DB_COL_STATE = "STATE";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LAST_NAME, c.LastName);
            operation.AddDateTimeParam(DB_COL_DATE_OF_BIRTH, c.DateOfBirth);
            operation.AddVarcharParam(DB_COL_SEX, c.Sex);
            operation.AddVarcharParam(DB_COL_STATE, c.State);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CUSTOMER_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CUSTOMER_PR" };

            var c = (Customer)entity;
       operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LAST_NAME, c.LastName);
            operation.AddDateTimeParam(DB_COL_DATE_OF_BIRTH, c.DateOfBirth);
            operation.AddVarcharParam(DB_COL_SEX, c.Sex);
            operation.AddVarcharParam(DB_COL_STATE, c.State);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Customer
            {



                Id = GetStringValue(row, DB_COL_ID),
                Name = GetStringValue(row, DB_COL_NAME),
                LastName = GetStringValue(row, DB_COL_LAST_NAME),
                DateOfBirth = GetDateValue(row, DB_COL_DATE_OF_BIRTH),
                Sex = GetStringValue(row, DB_COL_SEX),
                State = GetStringValue(row, DB_COL_STATE)
            };

            return customer;
        }

    }
}
