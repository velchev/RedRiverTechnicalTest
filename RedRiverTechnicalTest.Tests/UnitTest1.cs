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
            var hotDrinksMachine = new HotDrinksMachine();
            var drink = hotDrinksMachine.MakeDrink("chocolate"); //can make drink - Lemon Tea; Coffee or Chocolate
            //it dosn't matter which type we create we need to know the actions performed in crating the object
            var actions = drink.GetActionsPerformedDuringOperation();

            Assert.That(actions.Count, Is.GreaterThan(0));
        }
    }

    public class HotDrinksMachine
    {
        public Drink MakeDrink(string chocolate)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Drink
    {
        public List<string> GetActionsPerformedDuringOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}