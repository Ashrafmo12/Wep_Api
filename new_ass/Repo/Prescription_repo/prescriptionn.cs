using new_ass.DATA;
using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Prescription_repo
{
    public class prescriptionn : Iprescription
    {
        private readonly Appdbcontext _context;
        public prescriptionn(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(add_prescription prescription)
        {
            var p = new Prescription
            {
                Name = prescription.Name,
            };
            _context.Prescriptions.Add(p);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var p=_context.Prescriptions.FirstOrDefault(p => p.Id == id);
            _context.Prescriptions.Remove(p);
            _context.SaveChanges();
        }

        public IList<Prescription> GetAll()
        {
            return _context.Prescriptions.ToList();
        }
    }
}
