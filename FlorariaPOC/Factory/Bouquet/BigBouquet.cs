using Factory.Items;

namespace Factory.Bouquet
{
    internal class BigBouquet: Bouquet
    {
        public override void CreateItems()
        {
            Items.Add(new Flower());
            Items.Add(new Greenery());
            Items.Add(new Wrapping());
            Items.Add(new Spray());
        }
    }
}
