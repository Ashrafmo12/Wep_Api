namespace new_ass.models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
        public IList<Medicine>? Medicines { get; set; }

    }
}
