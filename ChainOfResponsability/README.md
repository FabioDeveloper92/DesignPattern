# Chain of Responsability Pattern

It's behavioral pattern, that eparates the objects that invoke the requests from the objects that manage them, giving each one the possibility to manage these requests.

![Chain of Responsability](https://pbs.twimg.com/media/FTnUYyYXwAARMe_?format=png&name=large)

## Problem

We need to decouple the sender of a request from the recipient.
Imagine receiving emails, and each of this email must be handled differently based on the type (bills, spam, work).

## Solutions

Upon receipt of a request we will create a hierarchical system, in which we will pass our request to each higher level until we find who will have to manage it.

## Use Case

- We have more than one object that can handle a request, but we don't know the manager a priori and it can be automatically selected
- The set of objects that handle a request can be dynamically defined
- A request is handled by one or more objects without specifying the recipient

## Participants

- Handler, defines the interface to manage requests, implements the next link to the hierarchy
- ConcreteHandler, manages the requests for which it is responsible; can access his successor; if it cannot handle the request, it propagates it to its successor
- Client, initiates the request to a concrete object that belongs to the chain of responsibility

## Pro

- Flexibility, the chain of responsibility can be changed without affecting the applicant.
- Reduces coupling: the applicant only needs to know that their request will be handled correctly.

## Cons

- Unsecured response: the request is taken over and propagated in the hierarchy but may not identify who is responsible and fail to give an answer or not managed
- Difficult to debug it
