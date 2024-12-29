using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_ass.DTOs;
using new_ass.Repo.Doctor_repo;
using new_ass.Repo.Prescription_repo;

namespace new_ass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class prescriptionController : ControllerBase
    {
        private readonly Iprescription _repo;
        public prescriptionController(Iprescription repo)
        {
            _repo = repo;
        }
        [HttpGet("GetAll")]
        public IActionResult Get() 
            {
            var list= _repo.GetAll();
            return Ok(list);
            }
        [HttpPost]
        public IActionResult Add(add_prescription add)
        {
            _repo.Add(add);
            return Created();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return NoContent();
        }
    }
}
