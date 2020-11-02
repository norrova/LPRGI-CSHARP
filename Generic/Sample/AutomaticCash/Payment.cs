using System;
using Generic.Sample.Human.Customer;

namespace Generic.Sample.AutomaticCash
{
    public class Payment
    {
        private DateTime m_time;
        private Customer m_customer;
        private double m_totalTTC;

        public DateTime Time { get => m_time; set => m_time = value; }
        public Customer Customer { get => m_customer; set => m_customer = value; }
        public double TotalTTC { get => m_totalTTC; set => m_totalTTC = value; }

        public Payment(DateTime p_datetime, Customer p_customer, double p_totalTTC)
        {
            Time = p_datetime;
            Customer = p_customer;
            TotalTTC = p_totalTTC;
        }

        public override string ToString()
        {
            return $"{Time} : {Customer} : {TotalTTC}";
        }
    }
}
