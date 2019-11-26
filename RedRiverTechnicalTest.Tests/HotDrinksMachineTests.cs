using NUnit.Framework;

namespace RedRiverTechnicalTest.Domain.Tests
{
    public class HotDrinksMachineTests
    {
        [Test]
        public void Verify_Actions_When_Building_Hot_Chocolate()
        {
            var hotDrinksMachine = new HotDrinksMachine(new ChocolateBuilder());
            hotDrinksMachine.MakeDrink();
            var drink = hotDrinksMachine.GetDrink();
            var actions = drink.GetActionsPerformedDuringOperation();
            // More than one assert is acceptable as we are testing the result of one method
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

 
}