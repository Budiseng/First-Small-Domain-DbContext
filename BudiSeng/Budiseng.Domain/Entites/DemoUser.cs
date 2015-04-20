using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budiseng.Dapper;

namespace Budiseng.Domain.Entites
{
    //
    //
    //  @ Project : Budiseng FirstDemo
    //  @ MIT License
    //  @ Date : 2015/4/11
    //  @ Author : Budiseng
    //
    //

    public class DemoUser : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
