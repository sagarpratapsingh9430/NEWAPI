using Microsoft.AspNetCore.Mvc;
using NEWAPI.Models;
using Microsoft.EntityFrameworkCore;
using NEWAPI.Repository;

namespace NEWAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApiController1 : Controller

    {
        private IFisrtRepository FirstRepo;

        public ApiController1(IFisrtRepository _FirstRepo)
        {
            FirstRepo = _FirstRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var a = FirstRepo.Get();
            return Ok(a);
        }
        [HttpPost]
        public IActionResult Create(ApiModel mac)
        {
            var a = FirstRepo.Create(mac);
            return Ok(a);
        }
        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            var a = FirstRepo.Edit(id);
            return Ok(a);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FirstRepo.Delete(id);
            return Ok();
        }

    }
}