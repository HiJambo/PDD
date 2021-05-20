using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDD.Core.Common;
using PDD.Core.IRepository.Stock;
using PDD.Core.Model;

namespace PDD.Core.Repository.Stock
{
    public class StockRepository : IStockRepository
    {
        public List<Model.Stock> GetStockList(string name, string id, string times)
        {
            throw new NotImplementedException();
        }

        public int StockAdd(Model.Stock Model)
        {
            throw new NotImplementedException();
        }

        public int StockDel(int id)
        {
            throw new NotImplementedException();
        }

        public int StockUpt(Model.Stock Model)
        {
            throw new NotImplementedException();
        }
    }
}
