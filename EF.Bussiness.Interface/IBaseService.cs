using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Bussiness.Interface
{
    public interface IBaseService : IDisposable
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entiy"></param>
        void Add<T>(T entiy) where T : class;

        #region Query
        T Find<T>(int id) where T : class;


        /// <summary>
        /// 查询，不应该暴露IQueryable<T>给上端
        /// 应当传入表达式目录树来查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="funcWhere"></param>
        /// <returns></returns>
        IQueryable<T> Query<T>(Expression<Func<T, bool>> funcWhere) where T : class;


        PageResult<T> QureyPage<T, S>(Expression<Func<T, bool>> funcWhere, int pageSize, int pageIndex, Expression<Func<T, S>> funcOrderby, bool isAcs = true) where T : class;

        #endregion

        #region Insert
        T Insert<T>(T t) where T : class;

        IEnumerable<T> Insert<T>(IEnumerable<T> tList) where T : class;
        #endregion

        #region update
        void Update<T>(T t) where T : class;

        void Update<T>(IEnumerable<T> tList) where T : class;
        #endregion


        #region Delete
        void Delete<T>(T t) where T : class;


        void Delete<T>(int Id) where T : class;


        void Delete<T>(IEnumerable<T> tList) where T : class;
        #endregion


        IQueryable<T> ExecteQuery<T>(string sql, SqlParameter[] parameters) where T : class;

        void Excute<T>(string sql, SqlParameter[] parameters) where T : class;
    }
}
