using System.Linq.Expressions;

namespace Domain.Entities
{
    public class ItemDrop : BaseEntity
    {
        public ItemDrop(int monsterId, int category, int index, int skill, int luck, int excellent, int rate, string name)
        {
            MonsterId = monsterId;
            Category = category;
            Index = index;
            Skill = skill;
            Luck = luck;
            Excellent = excellent;
            Rate = rate;
            Name = name;
        }

        public int MonsterId { get; set; }
        public int Category { get; set; }
        public int Index { get; set; }
        public int Skill { get; set; }
        public int Luck { get; set; }
        public int Excellent { get; set; }
        public int Rate { get; set; }
        public string Name { get; set; }

        protected ItemDrop() => Expression.Empty();
    }
}
