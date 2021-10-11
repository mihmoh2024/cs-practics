using System;

namespace pr1
{
  struct Person
  {
    public string firstname;
    public string lastname;
    public int age;
    public enum Gender : int { Male, Female };
    public Gender gender;
    public Person(string _firstname, string _lastname, int _age, Gender _gender)
    {
      firstname = _firstname;
      lastname = _lastname;
      age = _age;
      gender = _gender;
  }
    public override string ToString()
    {
      return firstname + " " + lastname + ",age" + age + " " + gender;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Mihail", "Smirnov", 19, Person.Gender.Male);
      Console.WriteLine(p);
      Console.ReadKey();
    }

  }
}
