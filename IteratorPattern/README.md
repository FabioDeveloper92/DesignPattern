# Iterator Pattern

It's a behavioral design pattern that an iterator is used to traverse a container and access the container's elements

## Problem

This pattern solves various problems related to access and navigation through the elements

In particular of a containing data structure, without exposing the details of the implementation and the internal structure of the container

## Solutions

The idea is to have a container that contains other objects inside
A container is associated with an iterator that represents an index to scroll inside the container
Each client will have its own iterator index to iterate through the container

## Use Case

- When your data collection has a complex data structure but you want to hide its complexity from clients
- You want to reduce duplication of the traversal code in your application
- When you want to be able to traverse different data structures or when the types of these structures are unknown in advance

## Participants

- Iterator, defines an interface to traverse the set of elements of a container and access individual elements
- ConcreteIterator, implements the Iterator creation interface and returns an instance of ConcreteIterator
- Aggregate, defines an interface for creating an Iterator object
- ConcreteAggregate, implements the Iterator interface by keeping track of the current position in the container and calculating what is next in the traversal sequence

## Pro

- Simplify the container interface by removing navigation through the contained elements
- Isolate the implementation details and the container structure, and hide them from data accessors, who use only the container and iterator interfaces
- Access the elements of a container through a uniform interface independent of the container type
- Simultaneously traverse the same aggregate of elements with multiple independent processes
- Traverse the same aggregate of elements in different ways

## Cons

- It's less efficient when going directly through the elements of some specialized collections, more memory is used than direct access to the elements
- Use in simple collections can be overkill
