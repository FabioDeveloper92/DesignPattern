# Memento Pattern

It's a behavioral pattern that is used when you need to restore the state of an object to its previous state

![Memento Pattern](https://pbs.twimg.com/media/FcoHCttWQAIlvrX?format=png&name=large)

## Problem

We need to save the state of the object, and then want to restore it under certain conditions

Ex: we think of the "Undo" function on any text editor, maybe we made a mistake in pasting something and we want to go back to the previous version of our text

## Solutions

We are going to create an object (memento) in which the state of an object, the originator, will be stored

The memento will have a double interface:
- that towards the originator, which allows you to save its internal state and restore it
- that towards the others, which will only expose the possible destroyer

## Use Case

- When you need a snapshot of your object, and you want restore it in case of error or others
- Undo operation in a application that need it (editor, game)
- Transaction management database

## Participants

- Caretaker, it's interested in the status of the Originator and holds the Memento object
- Originator, it stores its transient state through the use of internal properties while it stores its external state through the use of the Memento
- Memento, it's the object that takes care of holding the status of the Originator and allows only these to access it

## Pro

- Creating snapshots of the object state without violating its encapsulation
- You can discard non-essential changes and restore them to a stable state
- Easy recovery techniques

## Cons

- Storing all changes consumes excessive memory for each instance of Memento and this can lead to resource problems
- Caretaker must keep track of the originator life cycle in order to destroy outdated snapshots

### Note

The example is the classic example that is done with the memento pattern
You can do some optimizations such as saving only the states in certain optimizations or creating a queue of status changes that will be saved later
