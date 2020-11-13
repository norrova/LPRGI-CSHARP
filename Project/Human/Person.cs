using System;
namespace Project.Human
{
    public class Person
    {
        private String m_firstname;
        private String m_lastname;
        private int m_nbOrder;
        private int m_loyaltyPoint;

        public String Firstname { get => m_firstname; set => m_firstname = value; }
        public String Lastname { get => m_lastname; set => m_lastname = value; }
        public int NbOrder { get => m_nbOrder; set => m_nbOrder = value; }
        public int LoyaltyPoint { get => m_loyaltyPoint; set => m_loyaltyPoint = value; }

        public Person(String p_firstname, String p_lastname)
        {
            Firstname = p_firstname;
            Lastname = p_lastname;
        }

        public Person(String p_firstname, String p_lastname, int p_nbOrder)
            : this(p_firstname, p_lastname)
        {
            NbOrder = p_nbOrder;
        }

        public Person(string p_firstname, string p_lastname, int p_nbOrder, int p_loyaltyPoint)
            : this(p_firstname, p_lastname, p_nbOrder)
        {
            LoyaltyPoint = p_loyaltyPoint;
        }

        public override string ToString()
        {
            return $"Firstname : {Firstname}, Lastname : {Lastname}, Command : {NbOrder}, Loyalty points {LoyaltyPoint}";
        }
    }
}
