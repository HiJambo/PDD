using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDD.Core.Model;
using PDD.Core.Common;
using PDD.Core.IRepository.Distribution;
using PDD.Core.Repository.Distribution;


namespace PDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionController : ControllerBase
    {
        private readonly IDistributionRepository _distributionRepository;
        public DistributionController(IDistributionRepository distributionRepository)
        {
           _distributionRepository = distributionRepository;
        }
        //显示+查询
        [HttpGet]
        [Route("/api/GetDistributionList")]
       
        public IActionResult GetDistributionList(string name,int page,int limit)
        {
            var list = _distributionRepository.GetDistributionList(name);

            return Ok(new 
            {
                msg = "",
                code = 0,
                data = list.Skip((page-1)*limit).Take(limit),
                count=list.Count }
            );
        }
        [HttpPost]
        [Route("/api/DistributionDel")]
        public int DistributionDel(int id)
        {
            int i=0;
            i += _distributionRepository.DistributionDel(id);
            return i;
        }
    }
}
