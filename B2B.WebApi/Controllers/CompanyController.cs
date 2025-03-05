using B2B.Business.Abstract;
using B2B.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace B2B.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet]
        public IActionResult GetCompanyList()
        {
            var result=_companyService.GetList();
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }
        // BAŞARILI
        [HttpPost]
        public IActionResult AddCompany(Company company)
        {
            var result=_companyService.Add(company);
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }

    }
}
