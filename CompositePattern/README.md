# Composite Pattern

It's a structural pattern that organizes objects in a tree structure, in which the nodes are composites and the leaves are simple objects.

## Problem

When dealing with tree-structured data, it's often necessary to discriminate whether you are visiting a node or a leaf.
This difference could become very complex if not managed correctly.

## Solutions

By creating a Component interface, the Client interacts with the objects of the composite.
If the object is a Leaf then the request is processed, else it mean it's a Composite and it's sent to the children recursively.

## Use Case


- File system
- GUI
- Menu

In other words, in all those situations where we find ourselves in the scenario of building a tree hierarchy.

## Participants

- Component, it defines the interface of the objects of the composition.
- Composite, it defines the behavior of the objects used as containers and holds the reference to the “children” components
- Leaf, it represents the leaf object of the composition and hasn't children and defines the "primitive" behavior of the object of the composition

## Pro

- Easy to understand
- Easy to add new leaf and composite
- Client treats simple objects and container objects in the same way

## Cons

- Future changes to the composite properties are difficult to manage
- In case the classes differ too much, it is difficult to create a common interface without generalizing it too much and consequently more difficult to understand
