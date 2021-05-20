using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDD.Core.Common;
using PDD.Core.IRepository.Distribution;

namespace PDD.Core.Repository.Distribution
{
    public class DistributionRepository : IDistributionRepository
    {
        public List<Model.Distribution> GetDistributionList(string name)
        {
            string sql = $"select b.TName as TName_1,b.TPhone as TPhone_1 ,a.Hname,a.Hpath,a.Hplace from Distribution a join team b on a.Tid=b.Tid";
            return DapperHelper.GetList<PDD.Core.Model.Distribution>(sql);
        }

        public int DistributionDel(int id)
        {
            string sql = $"delete from Distribution where Hid={id}";
            return DapperHelper.Execute(sql);
        }

        public int DistributionUpt(Model.Distribution Model)
        {
            throw new NotImplementedException();
        }
    }
}
