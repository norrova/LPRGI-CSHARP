using System;
namespace Generic.Sample.Human.Student
{
    public class Student : Human
    {
        public Student(string p_name) : base (p_name)
        {
        }

        public override string ToString()
        {
            return $"Je suis un étudiant nommé {this.Name}";
        }
    }
}
