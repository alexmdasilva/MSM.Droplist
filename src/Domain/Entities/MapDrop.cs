using System.Linq.Expressions;

namespace Domain.Entities
{
    public class MapDrop : BaseEntity
    {
        public MapDrop(int mapId, int totalRate, ICollection<ItemDrop> itemDrops)
        {
            MapId = mapId;
            TotalRate = totalRate;
            ItemDrops = itemDrops;
        }

        public int MapId { get; set; }
        public int TotalRate { get; set; }
        public ICollection<ItemDrop> ItemDrops { get; set; }

        protected MapDrop() => Expression.Empty();
    }
}
