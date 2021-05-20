using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.Core.IRepository.CWarehouse
{
    public interface ICWarehouseRepository:IBaseRepository<PDD.Core.Model.CWarehouse>
    {

            List<PDD.Core.Model.CWarehouse> GetCWarehouseList(string name,string id,string times);//显示查询
            int CWarehouseDel(int id);//删除 
            int CWarehouseAdd(PDD.Core.Model.CWarehouse Model);//添加
            public int CWarehouseUpt(PDD.Core.Model.CWarehouse Model);//修改

        
    }
}
