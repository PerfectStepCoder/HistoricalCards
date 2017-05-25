using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model
{
    /// <summary>
    /// Категория исторических карточек
    /// </summary>
    public class Category: BaseEntity
    {
        List<Category> nodes = new List<Category>();

        protected int? IdParent { get; set; }

        public Category(int id):base(id)
        {

        }

        public void Add(Category category)
        {
            nodes.Add(category);
        }

        public void Remove(Category category)
        {
            nodes.Remove(category);
        }

        public Category GetChildById(int id)
        {
            return nodes[id] as Category;
        }
    }
}
