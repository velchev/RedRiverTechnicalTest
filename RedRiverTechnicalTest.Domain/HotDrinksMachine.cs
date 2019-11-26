using System;

namespace RedRiverTechnicalTest.Domain
{
    public class HotDrinksMachine
    {
        private readonly HotDrinkBuilder _builder;

        public HotDrinksMachine(HotDrinkBuilder builder)
        {
            _builder = builder ?? throw new ArgumentException("builder can not be null");
        }

        public void MakeDrink()
        {
            _builder.BoilSomeWater();
            _builder.MixMainIngredientWithWater();
            _builder.PourDrinkInCup();
            _builder.AddExtras();
        }

        public Drink GetDrink()
        {
            return _builder.GetDrink();
        }
    }
}