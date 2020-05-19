using AutoMapper;
using CodeFirst.Factories;
using EF.Bussiness.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Unity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerFactory.GetUnityContainer();

            using (IContainerService service = container.Resolve<IContainerService>())
            {
                var list = service.Query<Model.Container>(t => true).ToList();
            }


//            using (TransactionScope t = new TransactionScope())
//            {
//                //当前局域快的整个范围，多连接  多数据库  多请求 
//                //是Windows支持的DTC

//                t.Complete();
//            }


//            //非级联删除
//            using (var db = new WMSDBContext())
//            {
//                var usergroup = db.UserGroups.Include("Users").First();
//                List<User> removingUserList = new List<User>();
//                foreach (var item in usergroup.Users)
//                {
//                    removingUserList.Add(item);
//                }
//                removingUserList.ForEach(u => db.Users.Remove(u));
//                db.UserGroups.Remove(usergroup);
//                db.SaveChanges();
//;            }

//            UserGroup userGroup = new UserGroup
//            {
//                MenuGroupCode = "11",
//                UserGroupDesc = "11",
//                UserGroupNo = "11"
//            };

//            User user1 = new User
//            {
//                UserGroupID = userGroup.UserGroupID,
//                UserName = "user1",
//                UserPasswd = "123213"
//            };

//            User user2 = new User
//            {
//                UserGroupID = userGroup.UserGroupID,
//                UserName = "user2",
//                UserPasswd = "123213"
//            };

//            userGroup.Users = new List<User> { user1, user2 };

//            using (var db = new WMSDBContext())
//            {
//                db.UserGroups.Add(userGroup);
//                db.SaveChanges();
//            }

            //Stopwatch stopwatch = new Stopwatch();
            //using (var db = new WMSDBContext())
            //{
            //    stopwatch.Start();
            //    //针对导航属性的延时加载，默认是true
            //    db.Configuration.LazyLoadingEnabled = false;

            //    foreach (var item in db.Set<UserGroup>())
            //    {
            //        Console.WriteLine(item.UserGroupName);

            //        //重新加载出来
            //        db.Entry(item).Collection(u => u.Users).Load();
            //        foreach (var user in item.Users)
            //        {
            //            Console.WriteLine(user.UserName);
            //        }
            //        Console.WriteLine("-------------------------------");
            //    }
            //    stopwatch.Stop();
            //    Console.WriteLine($"一共花费{stopwatch.ElapsedMilliseconds}s\n\n");
            //}

            //using (var db = new WMSDBContext())
            //{
            //    stopwatch.Restart();
            //    //一次性全部加载
            //    foreach (var item in db.Set<UserGroup>().Include("Users"))
            //    {
            //        Console.WriteLine(item.UserGroupName);
            //        foreach (var user in item.Users)
            //        {
            //            Console.WriteLine(user.UserName);
            //        }
            //        Console.WriteLine("-------------------------------");
            //    }
            //    stopwatch.Stop();
            //    Console.WriteLine($"一共花费{stopwatch.ElapsedMilliseconds}s\n\n");
            //}


            Console.Read();
            //using(var db = new WMSDBContext())
            //{
            //    var list = db.View_InboundTaskDetail.ToList();
            //    var sre = list.Count();

            //    var lists = from u in db.Users
            //                join c in db.Containers
            //                on u.UserID equals c.Creater
            //                where new int[] { 1, 2, 3, 4 }.Contains(u.UserID)
            //                select new
            //                {
            //                    Account = u.UserName,
            //                };

            //    var lists1 = from u in db.Users
            //                join c in db.Containers
            //                on u.UserID equals c.Creater
            //                into ucList
            //                from uc in ucList.DefaultIfEmpty()
            //                where new int[] { 1, 2, 3, 4 }.Contains(u.UserID)
            //                select new
            //                {
            //                    Account = u.UserName,
            //                };

            //    Container container = new Container { };
            //    db.Containers.Attach(container);        //必须先附加，然后修改对象  负责不会生效

            //    db.Entry(container).State = EntityState.Modified;   //修改实体状态，但是这个会全部更新数据

            //    db.Entry(container).Property<string>("Id").IsModified = true;
            //}


            ////开启事务
            //WMSDBContext dbContext = null;
            //DbContextTransaction tran = null;
            //try
            //{
            //    dbContext = new WMSDBContext();
            //    tran = dbContext.Database.BeginTransaction();

            //    string sql = "";
            //    SqlParameter parameter = new SqlParameter("@Id", 1);
            //    dbContext.Database.ExecuteSqlCommand(sql, parameter);
            //    List<User> users = dbContext.Database.SqlQuery<User>(sql, parameter).ToList();
            //    tran.Commit();
            //}
            //catch (Exception)
            //{
            //    tran?.Rollback();
            //}
            //finally
            //{
            //    tran?.Dispose();
            //    dbContext?.Dispose();
            //}
        }
    }
}
