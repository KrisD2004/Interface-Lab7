# Interfaces-lab7


## Zoo Project Lab 6-A


## Introduction
The Zoo project is a console application that simulates a zoo with different types of animals. Each animal has specific behaviors and characteristics. The project utilizes object-oriented programming principles to model the zoo and its inhabitants.

## UML Diagram
Below is the digital UML diagram representing the structure of the Zoo project:


[Animal]
    |
  .-^-.
 /_/_\_\________
 |  _  |______  |
 |[_] |[#][_]| |
 | |_| |______| |
 |  _  |-=-=-=| |
 | [_] | [] []| |
 '-----'------'-' 

## Technical Documentation
### Object-Oriented Programming Principles

Abstraction: Abstraction is the process of hiding unnecessary details and exposing only relevant information. In the Zoo project, abstraction is achieved through abstract classes such as Animal, Mammal, Reptile, and Bird. These abstract classes define common properties and methods that are shared among their derived classes.
Examples in the project:
The Animal class defines abstract methods Eat() and Sound(), which are implemented in each concrete animal class (Lion, Eagle, Snake, Dolphin, and Elephant).
The Mammal class defines the abstract method GiveBirth(), which is implemented in mammal-related animal classes (Lion, Dolphin, and Elephant).

Inheritance: Inheritance allows classes to inherit properties and methods from other classes. It promotes code reuse and hierarchical organization of classes. In the Zoo project, inheritance is used to model the relationship between different types of animals.
Examples in the project:
The Lion class inherits from the Mammal class and overrides the abstract methods Eat(), Sound(), GiveBirth(), Sleep(), and Move().
The Eagle class inherits from the Bird class and overrides the abstract methods Eat(), Sound(), and Fly().
The Snake class inherits from the Reptile class and overrides the abstract methods Eat(), Sound(), and ShedSkin().
The Dolphin class inherits from the Mammal class and overrides the abstract methods Eat(), Sound(), and GiveBirth().
The Elephant class inherits from the Mammal class and overrides the abstract methods Eat(), Sound(), and GiveBirth().

Encapsulation: Encapsulation is the bundling of data and methods within a class, preventing direct access to the internal state of an object. It promotes data integrity and provides control over the object's behavior. In the Zoo project, encapsulation is achieved through the use of access modifiers and properties.
Examples in the project:
The Animal class has a public property Name, which allows accessing and modifying the name of an animal.
The Animal class has a virtual property Color, which can be overridden and accessed in the derived classes (Lion, Eagle, Snake, Dolphin, and Elephant).

Polymorphism: Polymorphism allows objects of different types to be treated as objects of a common base type. It enables methods to be called on objects without knowing their specific types, promoting flexibility and extensibility. In the Zoo project, polymorphism is demonstrated through method overriding.
Examples in the project:
The abstract method Sound() is overridden in each concrete animal class (Lion, Eagle, Snake, Dolphin, and Elephant), allowing them to produce their own specific sounds.
The abstract method GiveBirth() is overridden in mammal-related animal classes (Lion, Dolphin, and Elephant), each implementing their own birth behavior.
This documentation provides an overview of the key object-oriented programming principles utilized in the Zoo project. The application demonstrates the application of these principles by creating an object hierarchy of animals, encapsulating their behavior and characteristics, and allowing polymorphic behavior through method overriding.

## Zoo Project Lab 7-B

## Introduction
This readme provides an overview of the code implementation for the Interfaces Lab (Lab 5/Part 1). The code defines several abstract classes and concrete classes representing different animals, as well as an interface for animals that can fly.

## What is an Interface?
In object-oriented programming, an interface is a contract or blueprint for a class. It defines a set of method signatures that a class must implement if it wants to adhere to the interface. An interface does not contain any implementation details; it only declares the method signatures that must be present in the implementing classes. Interfaces allow us to achieve polymorphism, where different classes can be treated as instances of a common interface.

## Interfaces Implemented
The code implements an interface called IFlys, representing animals that can fly. This interface contains a property Wingspan and a method Fly(). The interface allows us to group different flying animals together and use them interchangeably.

## Interfaces Implementation in Classes
Eagle: The Eagle class is a concrete class derived from the Bird abstract class. It also implements the IFlys interface. The Eagle class overrides the abstract methods Eat() and Sound() from the Bird class and provides specific implementations. Additionally, it implements the Fly() method from the IFlys interface. The Eagle class demonstrates multiple inheritance, as it derives from both Bird and IFlys.

Bat: The Bat class is a concrete class derived from the Mammal abstract class and implements the IFlys interface. Similar to the Eagle class, the Bat class provides its implementations for the abstract methods Eat() and Sound() from the Mammal class and also implements the Fly() method from the IFlys interface.

## Diagram
Below is the updated class diagram representing the inheritance hierarchy and interfaces implemented in the code:



                                +-------------+
                                |   Animal    |
                                +-------------+
                                  ^         ^
                                  |         |
                 +----------------+         +-----------------+
                 |                                              |
           +-----------+                                   +-------------+
           |  Mammal   |                                   |   Reptile   |
           +-----------+                                   +-------------+
              ^     ^                                            ^
              |     |                                            |
+-------------------+                                    +------------+
|                  |                                    |           |
|    Elephant      |                                    |    Snake  |
|                  |                                    |           |
+------------------+                                    +------------+
              ^
              |
+----------------+
|               |
|    Bat        |
|               |
+---------------+

                        +-------+
                        | Bird  |
                        +-------+
                          ^
                          |
                +------------------+
                |                  |
         +------------+     +------------+
         |   Eagle    |     |   ...      |
         +------------+     +------------+
Conclusion
The code demonstrates the use of interfaces to implement behaviors that are not directly related to the class hierarchy. By implementing the IFlys interface, both the Eagle and Bat classes can be treated as flying animals and share common functionality. This lab showcases the power of interfaces and how they enable code reusability and flexibility in object-oriented programming.
