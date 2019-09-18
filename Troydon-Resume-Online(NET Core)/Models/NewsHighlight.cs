namespace Troydon_Resume_Online_NET_Core_.Models
{
    public class NewsHighlight
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; internal set; }
    }
}
