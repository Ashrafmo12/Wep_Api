namespace new_ass.DTOs
{
    public class add_patient
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public IList<Appoiments_dto>? Appointments { get; set; }
        public IList<Medidein_dto>? medidein_Dtos { get; set; }
        public string? prescription { get; set; }
    }
}
