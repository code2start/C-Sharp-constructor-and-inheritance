namespace constructorandinheritance
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}