# Visitor Pattern

It's a behavioral design pattern that allows to define the operations of an element without having to modify it

![Visitor Pattern](https://pbs.twimg.com/media/Fu4QnfdWwAMVIJb?format=jpg&name=large)

## Problem

We have many unrelated classes with a constant request for new operations, it becomes difficult to implement a new subclass for each new operation
Our system will have different classes of nodes, difficult to understand, maintain and modify

## Solutions

Let's create a ConcreteVisitor, which allows you to read the collection, and apply a method on each visited Element that extend an interface (Visitable)
The Visitor analyzes the type of object received and invokes an operation which must be performed in any case

## Use Case

- We operate on similar operations on objects of different types grouped in a collection
- We want to separate the unrelated behaviors from the class of the type into another class and we want to change the behaviors dynamically without changing the code of the classes
- We have the object hierarchy known in advance and with low probability of changes, but there is a strong probability of adding new operations in the future

## Participants

- Element, it's an interface that defines an accept operation used to "accept" a Visitor passed as a parameter
- ConcreteElement, it implements the Element interface
- ObjectStructure, it contains a collection of Elements that can be visited by Visitor objects
- Visitor, it's an interface it defines a visit method for each Element
- ConcreteVisitor, it implements the Visitor interface

## Pro

- If the logic of the operation changes then we have to modify only the implementation of the visitor rather than in all the classes
- Adding a new element to the system is simple, as you will only need to change in the visitor interface and implementation

## Cons

- If you remove or add an element, you must update all visitors
- Know at design time that the arguments and return type for visit methods must be known

