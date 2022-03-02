namespace Domain
{
    public class Map : BaseEntity
    {
        public Map(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; set; }
        public string Name { get; set; }
    }
}
