# Builder Pattern

It's a creational pattern that designed to provide a flexible solution for building a complex object step by step.

![Builder Pattern](https://pbs.twimg.com/media/FYruHdFX0AMN__H?format=png&name=large)

## Problem

A complex object could require a laborious and detailed initialization.
I mean that if we would have different constructors with different multiple fields, or subclasses that identify each type of our object.

## Solutions

We extract the construction code of the object from its own class and move it into separate objects called builders.
In this way the creation of a complex object is independent of the various parts that make up the object and how they are assembled.

## Use Case

- A complex object that requires many constructor with different parameters.
- In Unit Test, when you create an object and you need to pass many parameters to the constructor and some of these parameters are completely irrelevant to the specific test.
- Building Html.

## Participants

- Builder, it specifies the abstract class that creates the parts of the Product object.
- ConcreteBuilder, it builds and assembles parts of the product by implementing the Builder interface.
- Director, it builds an object using the Builder interface.
- Product, it represents the complex object and includes the classes that define the parts that compose it.

## Pro

- Reuse the same building code when you want to build objects represented differently.
- Step by step checks during the construction of the object.
- Separate the building code from the representation.

## Cons

- The only real disadvantage is that of having to define a builder class per class with a consequent increase in development time.
