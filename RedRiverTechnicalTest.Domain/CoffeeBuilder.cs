namespace RedRiverTechnicalTest.Domain
{
    public class CoffeeBuilder : HotDrinkBuilder
    {
        public override void MixMainIngredientWithWater()
        {
            Drink.AddAction("Brew the coffee grounds");
        }

        public override void PourDrinkInCup()
        {
            Drink.AddAction("Pour coffee in the cup");
        }

        public override void AddExtras()
        {
            Drink.AddAction("Add sugar and milk");
        }
    }
}