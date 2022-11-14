using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TalentPlusStaff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentPlusStaffController : ControllerBase
    {
        // GET: api/<TalentPlusStaffController>
        [HttpGet]
        public IEnumerable<TalentPlusStaffDetailsModel> Get()
        {
            TalentPlusStaffDetailsModel companyObj1 = new TalentPlusStaffDetailsModel();
            companyObj1.CompanyName = "TALENT PLUS";
            List<TalentPlusStaffDetailsModel> listofobj = new List<TalentPlusStaffDetailsModel>
            {
                companyObj1
               
            };
            return listofobj;
        }
    }
}


