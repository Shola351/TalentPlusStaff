using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalentPlusAttendance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentPlusAttendanceController : ControllerBase
    {
        // GET: api/<TalentPlusAttendanceController>
        [HttpGet]
        public IEnumerable<TalentPlusStaffAttendanceDetailsModel> Get()
        {
            TalentPlusStaffAttendanceDetailsModel companyObj1 = new TalentPlusStaffAttendanceDetailsModel();
            companyObj1.CompanyName = "TALENT PLUS";
            
            List<TalentPlusStaffAttendanceDetailsModel> listObj = new List<TalentPlusStaffAttendanceDetailsModel>
            {
                companyObj1
                
            };
            return listObj;
        }
    }
}
