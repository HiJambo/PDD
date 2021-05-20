using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDD.Core.Common;
using PDD.Core.IRepository.Inventory;
using PDD.Core.Model;

namespace PDD.Core.Repository.Inventory
{
    public class InventoryRepository : IInventoryRepository
    {
        public List<Model.Inventory> GetInventoryList(string name, string id, string times)
        {
            throw new NotImplementedException();
        }

        public int InventoryAdd(Model.Inventory Model)
        {
            throw new NotImplementedException();
        }

        public int InventoryDel(int id)
        {
            throw new NotImplementedException();
        }

        public int InventoryUpt(Model.Inventory Model)
        {
            throw new NotImplementedException();
        }
    }
}
