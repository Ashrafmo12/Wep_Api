using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Patient_repo
{
    public interface IPatient
    {
        public IList<Patient> GetAll();
        public Patient GetById(int id);
        public void Delete(int id);
        public void Update(add_patient patient,int id);
        public void Add(add_patient patient);
    }
}
