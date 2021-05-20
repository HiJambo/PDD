using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.Core.IRepository.Stock
{
    public interface IStockRepository:IBaseRepository<PDD.Core.Model.Stock>
    {
        List<PDD.Core.Model.Stock> GetStockList(string name, string id, string times);//显示查询
        int StockDel(int id);//删除 
        public int StockUpt(PDD.Core.Model.Stock Model);//修改
        int StockAdd(PDD.Core.Model.Stock Model);//添加
    }
}
