using Microsoft.EntityFrameworkCore;
using new_ass.DATA;
using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Patient_repo
{
    public class Patientt : IPatient
    {
        private readonly Appdbcontext _context;
        public Patientt(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(add_patient patient)
        {
            var p = new Patient
            {
                Name = patient.Name,
                Email = patient.Email,
                Appointments=patient.Appointments.Select(x=>new Appointment
                {
                    Date =x.Date,
                }).ToList(),
                Medicines=patient.medidein_Dtos.Select(x=>new Medicine
                {
                    Name=x.Name,
                }).ToList(),
                Prescription=new Prescription
                {
                    Name=patient.prescription
                }
            };
            _context.Patients.Add(p);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var p = GetById(id);
            _context.Patients.Remove(p);
            _context.SaveChanges();
        }

        public IList<Patient> GetAll()
        {
            var list = _context.Patients
                .ToList();

            return list;
        }

        public Patient GetById(int id)
        {
            return _context.Patients.FirstOrDefault(x=>x.Id==id);
        }

        public void Update(add_patient patient, int id)
        {
            var p=GetById(id);
            p.Name=patient.Name;
            p.Email=patient.Email;
            _context.Patients.Update(p);
            _context.SaveChanges();
        }
    }
}
