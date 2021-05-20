using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDD.Core.Common;
using PDD.Core.IRepository.CWarehouse;
using PDD.Core.Model;

namespace PDD.Core.Repository.CWarehouse
{
    public class CWarehouseRepository : ICWarehouseRepository
    {
        public int CWarehouseAdd(Model.CWarehouse Model)
        {
            string sql = $"insert into CWarehouse values({Model.WMid},'{Model.WModd}','{Model.WMWname}','{Model.WMGpic}','{Model.WMGname}','{Model.WMGsize}','{Model.WMGodd}','{Model.WMnum}','{Model.WMtime}')";
            return DapperHelper.Add(sql);
        }

        public int CWarehouseDel(int id)
        {
            string sql = $"delete from CWarehouse where WMid={id}";
            return DapperHelper.Execute(sql);
        }

        public int CWarehouseUpt(Model.CWarehouse Model)
        {
            string sql = $"update CWarehouse set WMid={Model.WMid},WModd='{Model.WModd}',WMWname='{Model.WMWname}',WMGpic='{Model.WMGpic}',WMGname='{Model.WMGname}',WMGsize='{Model.WMGsize}',WMGodd='{Model.WMGodd}',WMnum='{Model.WMnum}',WMtime='{Model.WMtime}'";
            int i = DapperHelper.Execute(sql);
            return i;
        }

        public List<Model.CWarehouse> GetCWarehouseList(string name, string id, string times)
        {
            string sql = $"select * from CWarehouse";
            return DapperHelper.GetList<PDD.Core.Model.CWarehouse>(sql);
        }
    }
}
