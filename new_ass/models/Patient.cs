namespace new_ass.models
{
    public class Patient
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public IList<Appointment>? Appointments { get; set; }
        public Prescription? Prescription { get; set; }
        public IList<Medicine>? Medicines { get; set; }


    }
}
