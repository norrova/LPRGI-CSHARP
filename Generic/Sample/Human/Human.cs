using System;
namespace Generic.Sample.Human
{
    public abstract class Human
    {
        private string m_name;
        protected string Name { get => m_name; set => m_name = value; }

        public Human(string p_name)
        {
            this.Name = p_name;
        }
    }
}
