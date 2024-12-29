using Microsoft.EntityFrameworkCore.Storage.Json;
using new_ass.DATA;
using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Doctor_repo
{
    public class Docrorr : IDoctor
    {
        private readonly Appdbcontext _context;
        public Docrorr(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(add_doctor doctor)
        {
            var d = new Doctor
            {
                Name = doctor.Name,
                Email = doctor.Email,
                Phone = doctor.Phone,
            };
            _context.Doctors.Add(d);
            _context.SaveChanges();
        }

        public IList<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }

        public void Update(add_doctor doctor, int id)
        {
           var d=_context.Doctors.FirstOrDefault(d => d.Id == id);
            d.Name = doctor.Name;
            d.Email = doctor.Email;
            d.Phone = doctor.Phone;
            _context.Doctors.Update(d);
            _context.SaveChanges();
        }
    }
}
