using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budiseng.Domain.DbContext
{
    //
    //
    //  @ Project : Budiseng FirstDemo
    //  @ MIT License
    //  @ Date : 2015/4/11
    //  @ Author : Budiseng
    //
    //
    public interface IRepositoryContext : IDisposable
    {
        IDbConnection Conn { get; }
        void InitConnection();
    }
}
