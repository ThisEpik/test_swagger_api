namespace test_swagger_api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

       public Person(int id, string name, int age) {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
