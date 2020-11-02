using System;
namespace Generic.Sample.Card
{
    public class CustomCard
    {
        private string m_color;
        public string Color { get => m_color; set => m_color = value; }
        private string m_type;
        public string Type { get => m_type; set => m_type = value; }

        public CustomCard(string p_color, string p_type)
        {
            Color = p_color;
            Type = p_type;
        }

        public override string ToString()
        {
            return $"{Color} : {Type}";
        }
    }
}
