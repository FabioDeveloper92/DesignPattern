# Mediator Pattern

It's a behavioral pattern that encapsulates the logic with which several objects interact with each other, avoiding that they have to dialogue directly

## Problem

Defining a set of objects that interact with each other by directly accessing and updating each other is not a flexible solution

Tightly coupling these objects together makes it impossible to modify the interaction independently of the objects, furthermore they are not reusable and difficult to test

## Solutions

Objects must interact with each other through a mediating object that controls and coordinates the interaction, in this way they have no explicit knowledge of each other

## Use Case

It's used when objects need to interact with each other to process the request, but a direct communication can create a complex system

Real case example:
- Traffic control
- Chat

## Participants

- Mediator, defines the interface for communication between Colleague objects
- ConcreteMediator, implements the Mediator interface and coordinates the communication between the Colleague and it know all colleague and their comunication purposes
- Colleague, defines the interface for communication with other Colleagues
- ConcreteColleague, implements the Colleague interface and communicates 

## Pro

- Reduce the complexity of communication between objects in a system
- Loose coupling
- Easy testing your Collegues
- Replacing “many-to-many” relationship with “one-to-many” relationships

## Cons

The implementation of the mediator is heavy, if one is not careful he can become an object of God

