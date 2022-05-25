# Abstract Factory

The Abstract Factory design pattern is one of the twenty-three well-known GoF (Gang of Four Design Patterns).

## What is

It's a creational design pattern, which solves the problem of creating entire product families without specifying their concrete classes.

## Goal

The scope is to provide an interface that allows you to create families of objects related to each other (same grouping at a logical level), without specifying the concrete type.

## Use Case

- create a system independent of how objects are created, composed and represented
- allow the configuration of the system as a choice between different product families
- organize products into families to be bound to be used with products from the same family
- provide a class library by showing only the interfaces and hiding the implementations.

## Partecipants

- AbstractFactory declares an interface for operations that create abstract product objects
- ConcreteFactory implements the operations to create concrete product objects
- AbstractProduct declares an interface for a type of product object
- ConcreteProduct defines a product object to be created by the corresponding concrete factory
- Client uses AbstractFactory and AbstractProduct interfaces to create a family
