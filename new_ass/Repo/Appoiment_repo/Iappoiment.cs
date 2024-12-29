using new_ass.DTOs;
using new_ass.models;

namespace new_ass.Repo.Appoiment_repo
{
    public interface Iappoiment
    {
        public Appointment GetById(int id);
        public void Add(Appoiments_dto dto);
        public void Update(Appoiments_dto dto, int id);
        public void Delete(int id);



    }
}
