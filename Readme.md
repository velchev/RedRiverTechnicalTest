# Red River Technical Test

You are required to model the operation of a hot drinks machine.  Based on the selection of a customer you will be required to make a drink according to a recipe for each choice.  
The recipes are:
### Lemon Tea
- Boil some water
- Steep the water in the tea
- Pour tea in the cup
- Add lemon
### Coffee
- Boil some water
- Brew the coffee grounds
- Pour coffee in the cup
- Add sugar and milk
### Chocolate
- Boil some water
- Add drinking chocolate powder to the water
- Pour chocolate in the cup

Create a web application to perform this task.

Based on the selection by the customer the application needs only to provide a readout on the actions performed during the preparation of the drink.


# Solution (Lyubomir Velchev)

I started with creating test with non existant class names just to make a skeleton of what I need as a result. Then using Resharper created the classes I needed in the test project. (In the end before using the web MVC moved the classes into its own class library project after implementing and refactoring.)

I noticed that the model of operation of hot drinks machine exactly fits with the bulder design pattern.

Builder is a creational design pattern that lets you construct complex objects step by step. 
The pattern allows you to produce different types and representations of an object using the same construction code. 
[more details here](https://refactoring.guru/design-patterns/builder)

Implemented the pattern for this particular case. All the drinks has one and the same first step - which is implemented in the abstract class HotDrinkBuilder. Then every bevarage bulder has different implementations of the next steps. The chocolate bulder dosn't have extras - so this step is not used for building the object. The implementation of every step is adding string to the list of actions done to crete a drink.

There are 3 tests to verify the correct creation of the 3 hot drinks.

The task required a web application to be created to perform this task. I have chosen the quickest solution - just MVC core application with no javascript or any front end framewrok.
