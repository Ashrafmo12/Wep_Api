using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_ass.DTOs;
using new_ass.Repo.Appoiment_repo;
using new_ass.Repo.Doctor_repo;

namespace new_ass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppoimentController : ControllerBase
    {
        private readonly Iappoiment _repo;
        public AppoimentController(Iappoiment repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get(int id) 
        {
           var s= _repo.GetById(id);
            return Ok(s);
        }
        [HttpPost]
        public IActionResult Add(Appoiments_dto dto)
        {
            _repo.Add(dto);
            return Created();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Upadte(Appoiments_dto dto,int id)
        {
            _repo.Update(dto,id);
            return Ok("Updated successfully");
        }
    }
}
