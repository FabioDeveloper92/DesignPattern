# Singleton Pattern

It's a creational design pattern that allows the creation of a class that has only one instance and provide a global access point to it

## Problem

We need to have only one instance of a class, for example when we need to access a shared resource
We want to have a global access point to this instance, we could also use global variables but anywhere in the code we could override them

## Solutions

There are several implementations of signleton but they have the same concept at basic:

- We make the default constructor private the constructor, which will then be called by a static build method
- This method will call the private constructor to create an object and save it in a static field

## Use Case

- Have controlled access to the single instance of the class
- Make sure you have a low number of objects used in sharing
- You can use it for logging, drivers, caching or thread pool

## Participants

- Singleton, it's a class that manages the object (with only one instance) in common with the other parts of our application
- Client, it use the singleton istance to do something

## Pro

- Encapsulate your creation so that you have full control over when and how it is accessed
- Singleton is created only when needed (lazy loading)
- Fast to create, as it doesn't need a large number of (global) variables

## Cons

- If used inappropriately, we will no longer have object-oriented programming but procedural
- As changes are made to the singleton it is not easy to know which program components will be affected and how they will behave
- In the case of multi-user applications, performance could be decreased, as it does not allow for a smooth flow of data
