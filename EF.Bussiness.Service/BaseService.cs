using EF.Bussiness.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Bussiness.Service
{
    /// <summary>
    /// 抽象是为了避免外面直接实例化
    /// </summary>
    public abstract class BaseService : IBaseService
    {
        protected DbContext Context { get; private set; }

        public BaseService(DbContext _context)
        {
            Context = _context;
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entiy"></param>
        public void Add<T>(T entiy) where T : class
        {
            Context.Set<T>().Add(entiy);
            Context.SaveChanges();
        }

        #region Query
        public T Find<T>(int id) where T : class
        {
            return Context.Set<T>().Find(id);
        }

        /// <summary>
        /// 查询，不应该暴露IQueryable<T>给上端
        /// 应当传入表达式目录树来查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="funcWhere"></param>
        /// <returns></returns>
        public IQueryable<T> Query<T>(Expression<Func<T, bool>> funcWhere) where T : class
        {
            return Context.Set<T>().Where(funcWhere);
        }


        public PageResult<T> QureyPage<T, S>(Expression<Func<T, bool>> funcWhere, int pageSize, int pageIndex, Expression<Func<T, S>> funcOrderby, bool isAcs = true) where T : class
        {
            var list = Context.Set<T>().AsQueryable();
            if (funcWhere != null)
            {
                list = list.Where(funcWhere);
            }
            if (isAcs)
            {
                list = list.OrderBy(funcOrderby);
            }
            else
            {
                list = list.OrderByDescending(funcOrderby);
            }
            PageResult<T> result = new PageResult<T>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = Context.Set<T>().Count(funcWhere),
                DataList = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList()
            };
            return result;
        }

        #endregion

        #region Insert
        public T Insert<T>(T t) where T : class
        {
            Context.Set<T>().Add(t);
            Commit();
            return t;
        }

        public IEnumerable<T> Insert<T>(IEnumerable<T> tList) where T : class
        {
            Context.Set<T>().AddRange(tList);
            Commit();
            return tList;
        }
        #endregion

        #region update
        public void Update<T>(T t) where T : class
        {
            Context.Set<T>().Attach(t);
            Context.Entry(t).State = EntityState.Modified;
            Commit();
        }

        public void Update<T>(IEnumerable<T> tList) where T : class
        {
            foreach (var item in tList)
            {
                Context.Set<T>().Attach(item);
                Context.Entry(item).State = EntityState.Modified;
            }
            Commit();
        }
        #endregion


        #region Delete
        public void Delete<T>(T t) where T : class
        {
            Context.Set<T>().Attach(t);
            Context.Set<T>().Remove(t);
            Commit();
        }


        public void Delete<T>(int Id) where T : class
        {
            T t = Find<T>(Id);
            Context.Set<T>().Remove(t);
            Commit();
        }


        public void Delete<T>(IEnumerable<T> tList) where T : class
        {
            foreach (var item in tList)
            {
                Context.Set<T>().Attach(item);
            }
            Context.Set<T>().RemoveRange(tList);
            Commit();
        }
        #endregion


        public IQueryable<T> ExecteQuery<T>(string sql, SqlParameter[] parameters) where T : class
        {
            return Context.Database.SqlQuery<T>(sql, parameters).AsQueryable();
        }

        public void Excute<T>(string sql, SqlParameter[] parameters) where T : class
        {
            DbContextTransaction transaction = null;
            try
            {
                transaction = Context.Database.BeginTransaction();
                Context.Database.ExecuteSqlCommand(sql, parameters);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction?.Rollback();
                throw;
            }
            finally
            {
                transaction?.Dispose();
            }
        }


        private void Commit()
        {
            Context.SaveChanges();
        }


        public virtual void Dispose()
        {
            Context?.Dispose();
        }
    }
}
