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
    public class ContainerService : BaseService, IContainerService
    {
        public ContainerService(DbContext context) : base(context) { }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
