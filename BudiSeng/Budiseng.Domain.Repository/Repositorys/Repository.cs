using System.Data;
using System.Linq;
using Budiseng.Dapper;
using Budiseng.Domain.DbContext;
using Budiseng.Domain.Entites;
using Budiseng.Domain.IRepositorys;
using Dapper;


namespace Budiseng.Domain.Repository.Repositorys
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
       {
       protected IRepositoryContext Context;
       protected IDbConnection Conn;

       public Repository(IRepositoryContext context)
       {
           Context = context;
           Conn = Context.Conn;
       }

        public T Add(T model)
        {
           return this.Conn.Insert(model);
        }

        public void Update(T model)
        {
            this.Conn.Update(model);
        }

        public T QueryFirst(object sqlParas)
        {
            return Conn.Select<T>(sqlParas).FirstOrDefault();
        }





        public System.Collections.Generic.List<T> Add(System.Collections.Generic.IList<T> modeList)
        {
            throw new System.NotImplementedException();
        }

        public void Update(System.Collections.Generic.IList<T> modeList)
        {
            throw new System.NotImplementedException();
        }

        public T Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T model)
        {
            throw new System.NotImplementedException();
        }

        public T QueryFirst(string sql, object sqlParas)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<T> Query(object sqlParas)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<T> Query(string sql, object sqlParas)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<T> Query(object sqlParas, int pageSize, int pageIndex)
        {
            throw new System.NotImplementedException();
        }
       }
}
