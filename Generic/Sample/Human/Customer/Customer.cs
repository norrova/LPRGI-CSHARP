using System;
namespace Generic.Sample.Human.Customer
{
    public class Customer : Human
    {
        public Customer(string p_name) : base(p_name)
        {
        }

        public override string ToString()
        {
            return $"Client nommé {this.Name}";
        }
    }
}
