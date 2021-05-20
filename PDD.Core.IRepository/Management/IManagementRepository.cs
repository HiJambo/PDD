using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.Core.IRepository.Management
{
    public interface IManagementRepository:IBaseRepository<PDD.Core.Model.Management>
    {
        List<PDD.Core.Model.Management> GetManagementList(string name,string id,string times);//显示查询
        int ManagementDel(int id);//删除 
        public int ManagementUpt(PDD.Core.Model.Management Model);//修改
        int ManagementAdd(PDD.Core.Model.Management Model);//添加
    }
}
