using System;
namespace csharp
{
    public class Human
    {
        private string m_first_name;
        private string m_last_name;
        private byte m_age;

        public string First_name { get => m_first_name; set => m_first_name = value; }
        public string Last_name { get => m_last_name; set => m_last_name = value; }
        public byte Age { get => m_age; set => m_age = value; }

        public Human(string p_firstName, string p_lastName, byte p_age)
        {
            First_name = p_firstName;
            Last_name = p_lastName;
            Age = p_age;
        }

        public override string ToString()
        {
            return $"je suis {First_name} {Last_name}, j'ai {Age} ans";
        }
    }
}
