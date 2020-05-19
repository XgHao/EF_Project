using EF.Bussiness.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Bussiness.Service
{
    public class UsergroupUserService : BaseService, IUsergroupUserService
    {
        public UsergroupUserService(DbContext context) : base(context)
        {
                
        }


        public void AddUsergroupUser(UserGroup userGroup, List<User> users)
        {
            throw new NotImplementedException();
        }
    }
}
