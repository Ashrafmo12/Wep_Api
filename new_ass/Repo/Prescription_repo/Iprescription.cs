using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Prescription_repo
{
    public interface Iprescription
    {
        public IList<Prescription> GetAll();
        public void Add(add_prescription prescription);
        public void Delete(int id);



    }
}
