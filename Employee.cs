namespace constructorandinheritance
{
    public class Employee : Person
    {
        public string Department { get; set; }
        public Employee(int id, string name, string department) : base(id, name)
        {
            this.Department = department;
        }
    }
}