﻿using DataAccess.Dao;
using DataAccess.Mapper;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Crud
{
    public class ListCrudFactory : CrudFactory
    {
        ListMapper mapper;


        public ListCrudFactory() : base()
        {
            mapper = new ListMapper();
            dao = SqlDao.GetInstance();
        }


        public override void Create(BaseEntity entity)
        {
            var optionList = (OptionList)entity;
            var sqlOperation = mapper.GetCreateStatement(optionList);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseEntity entity)
        {
            var optionList = (OptionList)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(optionList));
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var optionList = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    optionList.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return optionList;
        }

        public override void Update(BaseEntity entity)
        {
            var optionList = (OptionList)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(optionList));
        }
    }
}
