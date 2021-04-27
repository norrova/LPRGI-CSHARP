using System;
using Xunit;
using Generic.Utilities;

namespace TEst
{
    public class ListTest
    {
        [Fact]
        public void Add()
        {
            CustomList<string> v_list = new CustomList<string>();
            v_list.Add("elem");
            Assert.Equal(1, v_list.Count());
        }
    }
}
