# Prototype Pattern

It's a creational design pattern that creates objects based on an existing object by cloning

![Prototype Pattern](https://pbs.twimg.com/media/FgpznFHWYAQ3jpY?format=jpg&name=large)

## Problem

To create an object and create an exact copy, we should first create a new object, then copy the values ​​of the original object.
The problem is that you have to know the class of the object to create a duplicate, becoming dependent on that class.
In some cases only the interface following the object is known, but not the concrete class.

## Solutions

The cloning process is delegated to the actual objects that are cloned.
The clone method creates an object of the current class and passes all the values.

## Use Case

- The composition, creation and representation of the object must necessarily be separated
- Specifying which class to create at runtime
- There is a need to hide the complexity of object creation from the client
- Creating an object is a rather complex operation and therefore copying it is more convenient; when the necessary objects are similar to existing ones
- We want to avoid the creation of many parallel factories as happens in Abstract Factory

## Participants

- Prototype, it defines an interface to clone itself
- ConcretePrototype, it defines concrete classes that extend Prototype
- Client, it takes care of calling the cloning method on the ConcretePrototype

## Pro

- Independence of the instantiation method, client does not have to know what happens underneath
- Prototype is more flexible than other creational patterns, because adding a product simply requires registering the object to be cloned in a prototype manager
- You have to define numerous objs differentiated from each other only by the values ​​that their internal variables take

it's more convenient to instantiate new objs by cloning them from an initial prototype and then set the internal representation

## Cons

- The clone method must behave like a deep copy, i.e. that the copy is also applied in its sub-parts
- In some programming languages ​​using a simple copy (shallow copy), the clone operation must be redefined and could be complex in the presence of data structures
