using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budiseng.Domain.Infrastructure
{
    //
    //
    //  @ Project : Budiseng FirstDemo
    //  @ MIT License
    //  @ Date : 2015/4/11
    //  @ Author : Budiseng
    //
    //
    public interface IUnitOfWork
    {
        bool Committed { set; get; }
        IDbTransaction Tran { get; }
        void BeginTran();
        /// <summary>
        /// 提交当前的Unit Of Work事务。
        /// </summary>
        void Commit();
        /// <summary>
        /// 回滚当前的Unit Of Work事务。
        /// </summary>
        void Rollback();
    }
}
