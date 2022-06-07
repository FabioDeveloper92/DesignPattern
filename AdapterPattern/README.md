# Adapter pattern

Adapter pattern is a structural pattern that allows objects with different interfaces to collaborate.

## Problem

Whenever external libs are used in a project, whose interface isn't compatible with the existing application.
Instead of rewriting part of the system, very often it is an onerous task and the source code is not always available, it can be convenient to write an adapter.

## Solutions

Using an adapter, this object allows you to wrap an object hiding the difficulties of conversion. The wrapped object isn't even aware of the adapter.

## Use Case

- You are using an existing class that has an interface other than the one you want
- The writing of a class without being able to know the other classes with which it will have to work
- Invocation of a method of an object by clients occurs indirectly
- Maintain backward compatibility

## Participants

- Adaptee, defines the interface that needs to be adapted
- Target, defines the interface that the Client uses
- Client, collaborate with objects in accordance with the Target interface
- Adapter, adapt interface Adapt to Target interface

## Pro

- Separation of the interface or conversion from the primary business logic
- You can introduce several adapters without making many changes to the primary code but they work with the adapters through the client interface

## Cons

- Introducing new classes and interfaces we increase the complexity of our code.
- Sometimes, it may be easier to directly modify the client or adaptee interface.
