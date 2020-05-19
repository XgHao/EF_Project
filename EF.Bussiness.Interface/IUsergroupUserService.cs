using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Bussiness.Interface
{
    public interface IUsergroupUserService : IBaseService
    {
        void AddUsergroupUser(UserGroup userGroup, List<User> users);
    }
}
