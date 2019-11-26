namespace RedRiverTechnicalTest.Domain
{
    public class LemonTeaBuilder : HotDrinkBuilder
    {
        public override void MixMainIngredientWithWater()
        {
            Drink.AddAction("Steep the water in the tea");
        }

        public override void PourDrinkInCup()
        {
            Drink.AddAction("Pour tea in the cup");
        }

        public override void AddExtras()
        {
            Drink.AddAction("Add lemon");
        }
    }
}