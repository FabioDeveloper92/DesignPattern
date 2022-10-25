# State Pattern

It's a bahavioral pattern that allows an object to change its behavior at run-time according to the state it is in.

## Problem

We need to make an object change its behavior at run time, based on certain conditions.
Without the pattern, if-else conditional block sequences are normally used.

## Solutions

Creating new classes for all possible states, and for each one we extract its specific behaviors.
The original object (context) stores a reference to one of the state objects that represents its current state and delegates all state-related work to that object.

## Use Case

- The object must change behavior based on its state
- An object has complex operations implements by conditional statements

## Participants

- Context, it performs certain actions when it is in a particular state
- State, an interface that defines the common behavior associated with all possible states
- ConcreteState, represents a state and implements the State interface

## Pro

- The behavior of a state depends only on one class
- The logic that implements the change of state is implemented in a single class (Context), rather than with conditional statements (if or switch)
- Avoid inconsistent states

## Cons

- Increase number of class
- If a state machine has few states or rarely changes, using this pattern is inconvenient
