# Bridge pattern

It's a structural design pattern that decouples an abstraction from its implementation, so that the two can vary independently.

## Problem

When an abstraction has several implementations, inheritance is usually used, but this mechanism will link the abstraction with its implementation permanently.
This means that you will have many more classes and duplicate code.

## Solutions

Instead of creating N different abstractions, we choose to add a new property inside it, so that we can exclude some fictitious abstractions.

## Use Case

- you have a lot of classes resulting from a coupled interface and numerous implementations
- you wanna share an implementation among multiple objects
- you wanna a run-time binding of the implementation
- you need to map orthogonal class hierarchies

## Participants

- Implementor, defines the interface to be used as a Bridge and referable to the concrete objects to be used.
- Abstraction, defines the interface of the application domain used by the client.
- ConcreteImplementor, implements the Implementor interface used as a Bridge for the transit of objects.
- RefinedAbstraction, defines the implementation of the interface used.
- Client, who invokes the transaction of interest.

## Pro

- Abstraction and implementation are independently
- Single Responsibility Principle, update one component will not affect the others
- Less refactoring because the number of classes will increase a lot
- Multiple developers can work on different components simultaneously

## Cons

If you are not adding more functionality, this patter would add more classes.
