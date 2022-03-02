namespace Application.Queries.GetMapList
{
    public class GetMapListQueryResult
    {
        public IEnumerable<MapListItemResult> Maps { get; set; }
    }

    public class MapListItemResult
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
