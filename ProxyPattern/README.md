# Proxy Pattern

It's a structural pattern that provides an interface for objects that required resources and time to create it

![Proxy Pattern](https://pbs.twimg.com/media/FsELQYsXsAAkuQB?format=png&name=large)

## Problem

We need to get an object that consumes a lot of system resources
You could use lazy loading but that would duplicate the code in every class that will be used

## Solutions

Create a proxy class with the same interface as the original service object and we pass it in every point we need it
This way we hide lazy initialization and caching

## Use Case

- We need to hide the complexity of creation/access of an object of the client
- Control and manage access to a protected object (check a credit card, or our application had a limit to site access )

## Participants

- Proxy, it maintains a reference that allows the proxy to access to the object, it must implement the same interface of the reference object
- Subject, it's the interface for the object and proxy
- RealSubject, it's the real object that will be returned by the proxy

## Pro

- Manage the object without the client know the logics
- Decoupling the client and object optimizes the use of resources by postponing the execution of only when necessary potentially costly operations

## Cons

- It introduces a level of indirection in accessing an object. In general very complex operations can lead to degradation
