using System;
using Generic.Sample.Phone;

namespace Generic.Sample.Human.Person
{
    public class Person : Human
    {
        public Person(string p_name) : base(p_name)
        {
        }

        public override string ToString()
        {
            return $"Personne nommée {this.Name}";
        }
    }
}
