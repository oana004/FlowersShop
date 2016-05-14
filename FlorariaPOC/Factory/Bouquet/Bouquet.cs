using System.Collections.Generic;
using Factory.Items;

namespace Factory.Bouquet
{
    internal abstract class Bouquet
    {
        private List<Item> _items = new List<Item>();

        public Bouquet()
        {
            CreateItems();
        }

        public List<Item> Items { get { return _items; } }

        public abstract void CreateItems();
    }
}
