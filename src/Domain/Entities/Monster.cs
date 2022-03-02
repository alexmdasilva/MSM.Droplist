using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Monster : BaseEntity
    {
        public Monster(int index, string name)
        {
            Index = index;
            Name = name;
        }

        public int Index { get; set; }
        public string Name { get; set; }

        protected Monster() => Expression.Empty();
    }
}
