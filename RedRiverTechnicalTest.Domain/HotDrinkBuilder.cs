namespace RedRiverTechnicalTest.Domain
{
    public abstract class HotDrinkBuilder
    {
        protected Drink Drink = new Drink();
        public Drink GetDrink()
        {
            return Drink;
        }

        public void BoilSomeWater()
        {
            Drink.AddAction("Boil some water");
        }

        public abstract void MixMainIngredientWithWater();

        public abstract void PourDrinkInCup();

        public abstract void AddExtras();

    }
}
