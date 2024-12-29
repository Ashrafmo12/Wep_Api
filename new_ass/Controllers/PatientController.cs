using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_ass.DTOs;
using new_ass.Repo.Patient_repo;

namespace new_ass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatient _repo;
        public PatientController(IPatient repo)
        {
            _repo=repo;
        }

        [HttpPost]
        public IActionResult Add(add_patient patient)
        {
            _repo.Add(patient);
            return Created();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var list= _repo.GetAll();
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }
        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var list = _repo.GetById(id);
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
            {
               _repo.Delete(id);
               return NoContent();
            }
        [HttpPut]
        public IActionResult Update(add_patient patient,int id)
        {
            _repo.Update(patient, id);
            return Ok("Updated Successfully");
        }
    }
}
