using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace RedRiverTechnicalTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void Verify_That_There_Are_BuildActions_When_Making_Chocolate()
        {
            var hotDrinksMachine = new HotDrinksMachine(new ChocolateBuilder());
            hotDrinksMachine.MakeDrink(); //can make drink - Lemon Tea; Coffee or Chocolate
            var drink = hotDrinksMachine.GetDrink();
            //it dosn't matter which type we create we need to know the actions performed in crating the object
            var actions = drink.GetActionsPerformedDuringOperation();

            Assert.That(actions.Count, Is.GreaterThan(0));
        }

        [Test]
        public void Verify_Actions_When_Building_Hot_Chocolate()
        {
            var hotDrinksMachine = new HotDrinksMachine(new ChocolateBuilder());
            hotDrinksMachine.MakeDrink();
            var drink = hotDrinksMachine.GetDrink();
            var actions = drink.GetActionsPerformedDuringOperation();

            Assert.That(actions.Count, Is.EqualTo(3));
            Assert.That(actions[0], Is.EqualTo("Boil some water"));
            Assert.That(actions[1], Is.EqualTo("Add drinking chocolate powder to the water"));
            Assert.That(actions[2], Is.EqualTo("Pour chocolate in the cup"));

        }

        [Test]
        public void Verify_Actions_When_Building_Lemon_Tea()
        {
            var hotDrinksMachine = new HotDrinksMachine(new LemonTeaBuilder());
            hotDrinksMachine.MakeDrink();
            var drink = hotDrinksMachine.GetDrink();
            var actions = drink.GetActionsPerformedDuringOperation();

            Assert.That(actions.Count, Is.EqualTo(4));
            Assert.That(actions[0], Is.EqualTo("Boil some water"));
            Assert.That(actions[1], Is.EqualTo("Steep the water in the tea"));
            Assert.That(actions[2], Is.EqualTo("Pour tea in the cup"));
            Assert.That(actions[3], Is.EqualTo("Add lemon"));

        }

        [Test]
        public void Verify_Actions_When_Building_Coffee()
        {
            var hotDrinksMachine = new HotDrinksMachine(new CoffeeBuilder());
            hotDrinksMachine.MakeDrink();
            var drink = hotDrinksMachine.GetDrink();
            var actions = drink.GetActionsPerformedDuringOperation();

            Assert.That(actions.Count, Is.EqualTo(4));
            Assert.That(actions[0], Is.EqualTo("Boil some water"));
            Assert.That(actions[1], Is.EqualTo("Brew the coffee grounds"));
            Assert.That(actions[2], Is.EqualTo("Pour coffee in the cup"));
            Assert.That(actions[3], Is.EqualTo("Add sugar and milk"));
        }
    }

    public class HotDrinksMachine
    {
        private readonly HotDrinkBuilder _builder;

        public HotDrinksMachine(HotDrinkBuilder builder)
        {
            _builder = builder;
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

    public class Drink
    {
        private readonly List<string> _actions = new List<string>();

        public List<string> GetActionsPerformedDuringOperation()
        {
            return _actions;
        }

        public void AddAction(string steepTheWaterInTheTea)
        {
            _actions.Add(steepTheWaterInTheTea);
        }

        public List<string> GetActionsDoneToCrete()
        {
            return _actions;
        }
    }
}