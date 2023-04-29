# Observer Pattern

It's a behavioral pattern that allows you to define a one-to-many dependency between objects, so that if an object changes its internal state, each of the dependent objects is automatically notified and updated

![Observer Pattern](https://pbs.twimg.com/media/Fd1Ox6LUAAIaXdu?format=png&name=large)

## Problem

We need to upgrade to all objects that depend on a given class

The main need, therefore, is to maintain a high level of consistency between related classes, without producing situations of strong dependence and high coupling

## Solutions

We need an object, called subject, which will have to be observed in the long term and will notify the changes to the other objects (we can call it publisher)

The objects that observe the publisher's changes will be the observer

## Use Case

- GUI toolkit
- MVC architectural pattern
- Messaging systems
- Realtime systems
- Subscription systems
- Wherever it's necessary to notify of a change of status

## Participants

- Subject, it provides interface of methods to register, remove and notify observers
- ConcreteSubject, it implements the subject interface and the status is saved inside it
- Observer, it defines an interface for all observers, to receive notifications from the subject
- ConcreteObserver, it implements the Observer interface, defining the behavior in case of a change of state of the observed subject

## Pro

- It supports the principle of loose coupling between objects that interact with each other
- Observers can be added or removed in every moments
- Send data to other objects effectively without any changes in the Subject or Observer classes
- Subject and Observer are independent and a modification of one, doesn't require the modification of the other component

## Cons

- Subscribers are notified in random order
- If not implemented correctly, the Observer adds complexity and performance issues
