namespace Domain.Models
{
    public class Department
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Employee Manager { get; set; } // Bu Employee klassiga bog‘langan
    }
}
