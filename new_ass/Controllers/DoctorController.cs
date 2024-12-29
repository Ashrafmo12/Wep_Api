using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_ass.DTOs;
using new_ass.Repo.Doctor_repo;
using new_ass.Repo.Patient_repo;

namespace new_ass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctor _repo;
        public DoctorController(IDoctor repo)
        {
            _repo = repo;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
           var list = _repo.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Add(add_doctor doctor)
        {
            _repo.Add(doctor);
            return Created();
        }
        [HttpPut]
        public IActionResult Upadet(add_doctor doctor,int id)
        {
            _repo.Update(doctor, id);
            return Ok("Updated Successfully");
        }
    }
}
