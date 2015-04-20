using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Dapper;

namespace Budiseng.Dapper
{
    //参考自
    public static class DapperExtensions
    {
        public static T Insert<T>(this IDbConnection con, T item, IDbTransaction transaction = null) where T : IEntity
        {
            return con.Query<T>(DynamicQuery.GetInsertQuery(typeof(T).Name, item), item, transaction).First();
        }

        public static void Update<T>(this IDbConnection con,  T item, IDbTransaction transaction = null) where T : IEntity
        {
            con.Execute(DynamicQuery.GetUpdateQuery(typeof(T).Name, item), item, transaction);
        }
        public static IEnumerable<T> Select<T>(this IDbConnection con,object criteria = null)
        {
            var properties =PropertyManage.ParseProperties(criteria);
            var sqlPairs = PropertyManage.GetSqlPairs(properties.AllNames, " AND ");
            var sql = string.Format("SELECT * FROM [{0}] WHERE {1}", typeof(T).Name, sqlPairs);
            return con.Query<T>(sql, properties.AllPairs);
        }

    }

    public sealed class DynamicQuery
    {
        public static string GetInsertQuery<T>(string tableName, T item) where T : IEntity
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            var columns = props.Select(p => p.Name).Where(s => s != "Id").ToArray();

            return string.Format("INSERT INTO [{0}]({1}) OUTPUT inserted.Id VALUES (@{2})",
                                 tableName,
                                 String.Join(",", columns),
                                 String.Join(",@", columns));
        }

        public static string GetUpdateQuery<T>(string tableName, T item) where T : IEntity
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            var columns = props.Select(p => p.Name).Where(s => s != "Id").ToArray();

            var parameters = columns.Select(name => name + "=@" + name).ToList();

            return String.Format("UPDATE [{0}] SET {1} WHERE Id = @Id",
                                 tableName,
                                 String.Join(",", parameters));
        }
    }
}