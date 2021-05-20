using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDD.Core.Common;
using PDD.Core.IRepository.Management;
using PDD.Core.Model;

namespace PDD.Core.Repository.Management
{
    public class ManagementRepository : IManagementRepository
    {
        public List<Model.Management> GetManagementList(string name, string id, string times)
        {
            throw new NotImplementedException();
        }

        public int ManagementAdd(Model.Management Model)
        {
            throw new NotImplementedException();
        }

        public int ManagementDel(int id)
        {
            throw new NotImplementedException();
        }

        public int ManagementUpt(Model.Management Model)
        {
            throw new NotImplementedException();
        }
    }
}
