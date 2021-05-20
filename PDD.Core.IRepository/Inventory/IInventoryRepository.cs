using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.Core.IRepository.Inventory
{
    public interface IInventoryRepository:IBaseRepository<PDD.Core.Model.Inventory>
    {
        List<PDD.Core.Model.Inventory> GetInventoryList(string name, string id, string times);//显示查询
        int InventoryDel(int id);//删除 
        public int InventoryUpt(PDD.Core.Model.Inventory Model);//修改
        int InventoryAdd(PDD.Core.Model.Inventory Model);//添加
    }
}
