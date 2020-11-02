using System;
using System.Collections.Generic;

namespace Generic.Sample.AutomaticCash
{
    public class AutomaticCash
    {
        private uint m_id;
        public uint Id { get => m_id; set => m_id = value; }
        Queue<Payment> m_payments = new Queue<Payment>();

        public AutomaticCash(uint id)
        {
            Id = id;
        }

        public void AddPayment(Payment p_payment)
        {
            this.m_payments.Enqueue(p_payment);
        }

        public Payment GetFirstPayment()
        {
            return m_payments.Peek();
        }

        public void Print()
        {
            foreach (Payment v_item in m_payments)
            {
                Console.WriteLine(v_item);
            }
        }
    }
}
