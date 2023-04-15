# Template Method Pattern

It's a behavioral design pattern that used to define the structure of an algorithm by delegating some detail steps to the subclasses

## Problem

We have several classes that implement the same algorithm, using code that is very similar to each other, and in some cases it is duplicated
Also, I may end up with client code using these classes, it's using many conditions to choose the correct way to run this algorithm

## Solutions

The solution is to create an abstract class that defines

- primitive operations, must be redefined in subclasses
- hook methods, which can be overridden or inherited
- non-overridable methods defined only in the abstract class and not usable by subclasses

## Use Case

- You want to implement the invariant part of an algorithm only once and let subclasses implement the behavior that can vary
- When common behavior can be factored into a class to avoid duplicate code
- To have a way to control how subclasses inherit from superclasses

## Participants

- Abstract Class, it defines the operations that the underlying concrete classes will implement/reuse as well as the template method which represents the skeleton of the algorithm
- Concrete Class, it implements/reuses superclass operations


## Pro

- Code reusability and standard steps to follow
- Flexibility of concrete implementations
- Useful when there is a standard model and several behaviors in the concrete subclasses


## Cons

- Sometimes confusing and hard to deal with if you don't understand abstract superclass
- If you have many steps in template methods, management can be complicated
- In some cases, the skeleton provided can be limiting for some clients
