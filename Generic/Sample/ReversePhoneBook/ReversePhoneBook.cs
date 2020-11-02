using System;
using System.Collections.Generic;
using Generic.Sample.Human.Person;

namespace Generic.Sample.ReversePhoneBook
{
    public class ReversePhoneBook
    {
        private SortedList<string, Person> m_reversePhone;

        public SortedList<string, Person> ReversePhone { get => m_reversePhone; set => m_reversePhone = value; }

        public ReversePhoneBook(SortedList<string, Person> p_reversePhone)
        {
            this.ReversePhone = p_reversePhone;
        }

        public Person Search(string p_number)
        {
            Person v_customer = null;
            try
            {
                v_customer = ReversePhone[p_number];
            }
            catch
            {
                throw new Exception("Number not found");
            }
            return v_customer;
        }

        public void Print()
        {
            foreach(var v_item in ReversePhone)
            {
                Console.WriteLine($"{v_item.Key} : {v_item.Value}");
            }
        }

    }
}
