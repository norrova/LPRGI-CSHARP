using System;
namespace Generic.Utilities
{
    public interface IList<T>
    {
        public void Add(T p_elem);
        public int Count();
        public T Get(uint p_index);
        public void Print();
    }
}
