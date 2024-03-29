﻿using System;
using System.Collections.Generic;
using Entities_POJO;
using DataAcess.Mapper;
using DataAcess.Dao;
using DataAcess.Crud;
using DataAccess.Mapper;

namespace DataAccess.Crud
{
    public class DirectionCrudFactory : CrudFactory
    {
        DirectionMapper mapper;

        public DirectionCrudFactory() : base()
        {
            mapper = new DirectionMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var direction = (Direction)entity;
            var sqlOperation = mapper.GetCreateStatement(direction);
            dao.ExecuteProcedure(sqlOperation);
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
            var lstDirections = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstDirections.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstDirections;
        }

        public override void Update(BaseEntity entity)
        {
            var direction = (Direction)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(direction));
        }

        public override void Delete(BaseEntity entity)
        {
            var direction = (Direction)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(direction));
        }


    }
}
