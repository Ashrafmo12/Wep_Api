using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Doctor_repo
{
    public interface IDoctor
    {
        public IList<Doctor> GetAll();
        public void Update(add_doctor doctor, int id);
        public void Add(add_doctor doctor);

    }
}
