using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InsuranceClaim.Model;
using InsuranceClaim.Repository;

namespace InsuranceClaim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceClaimController : ControllerBase
    {
        // GET: InsuranceClaimController
        InsurerDetailRepository Insurer = new InsurerDetailRepository();
        [HttpGet("GetAllInsurerDetail")]
        public IActionResult GetAllInsurerDetail()
        {
            try
            {
                List<InsurerDetail> insurer = Insurer.GetAllInsurerDetail();
                if (insurer == null)
                    return NotFound();
                return Ok(insurer);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet("GetInsurerByPackageName/{PackageName}")]
        public IActionResult GetInsurerByPackageName(String PackageName)
        {
            try
            {
                InsurerDetail insurer = Insurer.GetInsurerByPackageName(PackageName);
                if (insurer == null)
                    return NotFound();
                return Ok(insurer);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
