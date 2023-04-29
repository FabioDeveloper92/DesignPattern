# Decorator Pattern

It's a structural design pattern that allows you to add functionality or change the behavior of an object at runtime

![Decorator Pattern](https://pbs.twimg.com/media/FjnuDQvXEAEr1zY?format=jpg&name=large)

## Problem

When using object-oriented programming, inheritance is the model used to extend the functionality of the object
When using this approach, there is a risk of exploding the class hierarchy, in the sense that children are created, then children of children are added and so on (this phenomenon is called Exploding class hierarchy)


## Solutions

Let's build a new decorator class that "wraps" the original object
To the constructor of the decorator we pass them either the original object, or, another decorator
With the latter approach one can chain multiple decorators together, incrementally adding functionality to the concrete class (which is represented by the last link in the chain)

## Use Case

- Explosion of classes in a hierarchy
- Dynamically add/remove features

## Participants

- Component, it defines the interface of the object to which new functionality will be added
- Decorator, it maintains a reference to the Component object and defines an interface that conforms to the Component interface
- ConcreteComponent, it defines the concrete object to add the functionality to
- ConcreteDecorator, it adds functionality to the Component

## Pro

- Simplify class hierarchy and improve testability
- Add or remove responsibilities from an object at runtime

## Cons

- All methods in the decorator interface must be implemented in the concrete decorator class, even if they are not needed
- Increased complexity when creating a component that is wrapped in many decorators
- Complexity keep track of other decorators used in the creation
