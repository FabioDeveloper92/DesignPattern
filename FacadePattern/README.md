# Facade Pattern

It's a Structural design pattern that hides the complexity of a system and offers an interface to clients who want to access it client

## Problem

We are in a situation where we have ante classes that perform related functions and the set of interfaces can be complex to manage

We also want to try to reduce direct communications and dependencies between the client and the subsystem

## Solutions

We create a single simplified interface thathides subsystem objects from clients, consequently this reduces the complexity of the interface and therefore of the calls

## Use Case

- We want a uniform interface for accessing complex subsystems or any number of objects
- We want minimize dependency between clients and critical subsystems
- We want to plan a software project that must be divided into several levels

## Participants

- Facade, it knows what the underlying system is like and he will be the one who will take care of invoking the correct methods
- Subsystem, it's composed of concrete classes that implement the functionality, it doesn't know about the existence of the facade

## Pro

- Minimizes subsystem complexity
- Favors the principle of loose coupling
- It makes the software more flexible and easily reusable

## Cons

- It could become a god object coupled to all classes
- Complicated implementation (particularly within existing code)
- Adds a level of indirection and the consequent lengthening of the times for the processing of the method invocation, for memory access, etc.
