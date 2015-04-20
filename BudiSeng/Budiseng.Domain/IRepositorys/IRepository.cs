using System;
using System.Collections.Generic;

namespace Budiseng.Domain.IRepositorys
{   
    //
    //
    //  @ Project : Budiseng FirstDemo
    //  @ MIT License
    //  @ Date : 2015/4/11
    //  @ Author : Budiseng
    //
    //
    public interface IRepository<T>
        where T : class
    {
        T Add(T model);
        List<T> Add(IList<T> modeList ); 
        void Update(T model);
        void Update(IList<T> modeList);
        T Find(int id);
        void Remove(int id);
        void Remove(T model);
        T QueryFirst(object sqlParas);
        T QueryFirst(string sql, object sqlParas);
        IList<T> Query(object sqlParas);
        IList<T> Query(string sql, object sqlParas);
        IList<T> Query(object sqlParas,int pageSize,int pageIndex);
        
    }
}
