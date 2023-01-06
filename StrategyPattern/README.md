# Strategy Pattern

It's behavioral pattern, that allows you to isolate a set of algorithms outside the class that uses them, to ensure that the latter can use them interchangeably, making its behavior dynamic

## Problem

There are some situations where it is necessary to dynamically change the algorithms used
So we want to have a way to vary the strategies to solve a problem easily

## Solutions

We define an interface for strategies and instantiate them concrete classes for each strategy
The client user accesses the strategies through the interfaces

## Use Case

- There are several similar classes that differ in their ownbehavior for a given method
- An algorithm uses data that clients shouldn't know
- A class defines several behaviors that come activated as a result of conditional statements (switch, if else)

## Participants

- Context, it's the application context of the problem, keeps a reference to the strategy to apply
- Strategy, it's the common interface for the algorithm versions
- ConcreteStrategy, it implement the interface Strategy

## Pro

- You can change your algorithm without also changing the context
- Avoid using complex conditional statements
- Choose the algorithm to use at runtime


## Cons

- Clients need to know that different strategies exist and choose the correct one to apply
- Different algorithms must have the same interface
- Increasing the number of entities in the project
