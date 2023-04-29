# Flyweight  Pattern

It's a structural design pattern that allows you to separate the variable part of a class from the part that can be reused, in such a way as to share the latter among different instances

![Flyweight  Pattern](https://pbs.twimg.com/media/Fq8KmHlXgAI574l?format=jpg&name=large)

## Problem

In some cases we need to generate a lot of instances of small classes to represent the data (mageri these instances differ only for some parameters)
This increases excessive memory usage, causing the application to crash

## Solutions

We create shared objects that can be used simultaneously in different contexts
They will have an immutable internal (or intrinsic) state and a parameterizable part (what they differ)

## Use Case

- You create many objects similar to each other, and they use a lot of memory
- The state of the object can be saved outside of it
- 
## Participants

- Flyweight, it contains a part of the state, the properties in here store unique values
- Context, it contains the external state (that is, the one that differentiates it), and the intrinsic state, our application could create many of these objects
- FlyweightFactory, it creates and manages flyweight objects, making the same instance available to anyone who needs it

## Pro

- If you use lots of similar objects, you save a lot of RAM
- 
## Cons

- If you don't have a memory problem, using this pattern is useless
- The code will become very complicated
- If they are not shareable properties, it complicates the code
