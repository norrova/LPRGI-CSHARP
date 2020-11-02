using System;
namespace Generic.Sample.Phone
{
    public class PhoneNumber
    {
        private string m_number;
        public string Number { get => m_number; set => m_number = value; }

        public PhoneNumber(string p_number)
        {
            this.Number = p_number;
        }

    }
}
