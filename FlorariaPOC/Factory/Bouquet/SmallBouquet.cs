using Factory.Items;

namespace Factory.Bouquet
{
    internal class SmallBouquet: Bouquet
    {
        public override void CreateItems()
        {
            Items.Add(new Flower());
            Items.Add(new Wrapping());
        }
    }
}
