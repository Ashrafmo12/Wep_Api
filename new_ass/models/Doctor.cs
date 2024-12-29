﻿namespace new_ass.models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public IList<Appointment>? Appointments { get; set; }
    }
}
