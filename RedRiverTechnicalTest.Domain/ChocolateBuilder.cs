namespace RedRiverTechnicalTest.Domain
{
    public class ChocolateBuilder : HotDrinkBuilder
    {
        public override void MixMainIngredientWithWater()
        {
            Drink.AddAction("Add drinking chocolate powder to the water");
        }

        public override void PourDrinkInCup()
        {
            Drink.AddAction("Pour chocolate in the cup");
        }

        public override void AddExtras()
        {
            //no extras for chocolate
        }
    }
}