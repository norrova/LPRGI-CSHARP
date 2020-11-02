using System;
namespace Generic.Utilities
{
    public class CustomList<T> : IList<T>
    {
        private T[] m_array;

        public CustomList()
        {
            m_array = new T[0];
        }

        public CustomList(params T[] p_elements)
        {
            m_array = p_elements;
        }

        public void Add(T p_elem)
        {
            Array.Resize<T>(ref m_array, m_array.Length + 1);
            m_array[m_array.Length - 1] = p_elem;
        }

        public int Count()
        {
            return m_array.Length;
        }

        public T Get(uint p_index)
        {
            T m_item = default;
            try
            {
                m_item = m_array[p_index];
            }
            catch(IndexOutOfRangeException)
            {
                throw;
            }
            return m_item;
        }

        public void Print()
        {
            foreach (T element in m_array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
