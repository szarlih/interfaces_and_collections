namespace _2_interfejsy_kolekcje
{
    public class MeaningfulNameElement : IElement
    {
        private string _oryginalName;

        public MeaningfulNameElement()
        {
            Weight = 0;
            Name = string.Empty;
        }

        public MeaningfulNameElement(int weight)
        {
            Weight = weight;
            Name = string.Empty;
        }

        public MeaningfulNameElement(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public string Name
        {
            get
            {
                return Weight + _oryginalName;
            }

            set
            {
                _oryginalName = value;
            }
        }

        public int Weight { get; private set; }
    }
}
