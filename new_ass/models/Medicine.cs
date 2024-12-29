namespace new_ass.models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IList<Patient>? Patients { get; set; }
        public int? PrescriptionId { get; set; }
        public Prescription? Prescription { get; set; }

    }
}
