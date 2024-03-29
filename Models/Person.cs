using System.Diagnostics.CodeAnalysis;

namespace test_swagger_api.Models
{
    [method: SetsRequiredMembers]
    public class Person(int id, string name, int age)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
    }
}
