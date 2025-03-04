using B2B.Business.Abstract;
using B2B.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace B2B.WebApi.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet("getcompanylist")]
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
        [HttpPost("addedcompany")]
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
