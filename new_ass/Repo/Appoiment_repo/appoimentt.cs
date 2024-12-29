using Microsoft.EntityFrameworkCore;
using new_ass.DATA;
using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Appoiment_repo
{
    public class appoimentt : Iappoiment
    {
        private readonly Appdbcontext _context;
        public appoimentt(Appdbcontext context)
        {
            _context = context;
        }

        public void Add(Appoiments_dto dto)
        {
            var a = new Appointment
            {
                Date = dto.Date,
                Doctor =new Doctor
                {
                    Name=dto.Doctorname
                },
                Patient=new Patient
                {
                    Name =dto.Patientname
                }
            };
            _context.Appointments.Add(a);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var a=_context.Appointments.FirstOrDefault(x => x.Id == id);
            _context.Appointments.Remove(a);
            _context.SaveChanges();
        }

        public Appointment GetById(int id)
        {
            var appointment = _context.Appointments
                .Include(a => a.Doctor) 
                .Include(a => a.Patient)
                .FirstOrDefault(x => x.Id == id);

            if (appointment != null)
            {
                var doctorName = appointment.Doctor.Name;
                var patientName = appointment.Patient.Name;
            }
            return appointment;
        }

        public void Update(Appoiments_dto dto, int id)
        {
           var a=_context.Appointments.FirstOrDefault(x => x.Id == id);
            a.Date = dto.Date;
            _context.Appointments.Update(a);
            _context.SaveChanges();
        }

    }
}
