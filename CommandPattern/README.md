# Command Pattern

It's a behavioral pattern that allows you to isolate the portion of code that performs an action (possibly very complex) from the code that requires its execution; the action is encapsulated in the Command object.

## Problem

We want to avoid matching a invoker to a particular request, so wired requests should be avoided.
Implementing a request directly into an object isn't a good solution because it matches the class to a particular request at compile time, which makes it impossible to specify a request at run time.

## Solutions

What we need is to define separate objects that encapsulate a request. A class delegates a request to another object instead of directly implementing the request.
In this way we configure a class with a command object that will be used to execute a request, consequently the class is no longer coupled to a particular request and is independent of how the request is executed.

## Use Case

- A command must have a duration independent of the original request or, if you want to queue, specify and execute requests at different times.
- Undo / redo operations are required. The execution of the command can be stored to reverse its effects. It is important that the Command class implement the undo and redo methods.
- It's necessary to structure a system around high-level operations based on primitive operations.

## Participants

- Command, it's interface for declaring an operation
- ConcreteCommand, extends the command interface and has the execution method to invoke methods.
- Invoker, gives them the command object to perform the operation.
- Receiver, who execute the actions

## Pro

- Decouples the classes that invoke the operation from the object that knows how to perform the operation
- Allows you to create a sequence of commands by providing a queuing system
- Extensions to add a new command are easy and can be done without modifying existing code
- You can define a rollback system

## Cons

- Increased number of classes for each single command, in a different view. It may not be preferred in some specific scenarios.
