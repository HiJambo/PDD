using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.Core.IRepository.Distribution
{
    public interface IDistributionRepository:IBaseRepository<PDD.Core.Model.Distribution>
    {
       List<PDD.Core.Model.Distribution> GetDistributionList(string name);//显示查询
        int DistributionDel(int id);//删除 
        public int DistributionUpt(PDD.Core.Model.Distribution Model);//修改
    }
}
