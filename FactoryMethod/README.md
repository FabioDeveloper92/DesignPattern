# Factory Method

The factory method pattern is a creational pattern that provides an interface to create an object, but lets the subclasses decide which object to instantiate.

## Problem

The creation of an object can require very complex processes whose placement has been found to be inappropriate within a class
It could require duplication to request information not accessible to the creation class & you risk not having the right level of abstraction

## Use Case

- When we create an object it precludes reuse without duplicating the code
- Creating an object requires the use of resources that should not be contained within the class
- The management of the life cycle of managed objects must be centralized to ensure consistent behavior within the application

## Participants

- Creator/Factory, it declares the factory method, which returns an object of type Product
- ConcreteCreator, it overrides the factory method declared in Creator to return an instance of a ConcreteProduct
- Product, it defines an interface for the objects the factory method creates
- Concrete Product, the object that implements Product interface

## Pro

- Respect the Single Responsibility Principle (SOLID Principle)
- Allows you to easily test (you create a mock/stub more easily)
- Allows you to change the design of your application more readily (Loose coupling)

## Cons

- The code may become more complex because many new subclasses need to be introduced to implement the model.
