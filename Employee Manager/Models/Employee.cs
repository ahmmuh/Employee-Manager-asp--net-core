namespace Employee_Manager.Models
{
    public class Employee
    {
        public int Id  { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }

    }
}
