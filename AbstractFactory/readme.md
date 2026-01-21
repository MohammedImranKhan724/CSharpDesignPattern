# Abstract Factory Design Pattern

## Definition

According to the *Gang of Four (GoF)*, the **Abstract Factory Design Pattern** provides a way to encapsulate a group of factories with a common theme **without specifying their concrete classes**.

> **Abstract** means hiding implementation details, **Factory** means an object responsible for creating other objects, and **Pattern** means a reusable design solution.

In simple terms, the **Abstract Factory Pattern** is a **factory of factories**. It provides an interface for creating families of related or dependent objects without specifying their concrete implementations.

---

## Purpose

* To create **families of related objects**
* To **decouple client code** from concrete implementations
* To enforce **consistency** among products belonging to the same family

---

## When to Use

* When the system should be independent of how its objects are created
* When multiple families of related products exist
* When you want to switch product families easily

---

## Components of Abstract Factory Design Pattern

### 1. AbstractFactory

* Declares an interface for creating abstract products
* Contains factory methods for each product type

```text
interface AbstractFactory {
    createProductA();
    createProductB();
}
```

---

### 2. ConcreteFactory

* Implements the `AbstractFactory` interface
* Responsible for creating concrete product objects
* Each factory creates products belonging to one family

```text
class ConcreteFactory1 implements AbstractFactory
class ConcreteFactory2 implements AbstractFactory
```

---

### 3. AbstractProduct

* Declares interfaces for product types
* Defines common behavior for all products

```text
interface AbstractProductA
interface AbstractProductB
```

---

### 4. ConcreteProduct

* Implements the `AbstractProduct` interfaces
* Represents actual objects created by factories

```text
class ConcreteProductA1 implements AbstractProductA
class ConcreteProductA2 implements AbstractProductA
```

---

### 5. Client

* Uses only `AbstractFactory` and `AbstractProduct` interfaces
* Does **not depend on concrete implementations**

```text
Client → AbstractFactory → AbstractProduct
```

---

## Advantages

* Promotes **loose coupling**
* Makes switching product families easy
* Ensures product compatibility
* Follows **Open/Closed Principle**

---

## Disadvantages

* Increases code complexity
* Difficult to add new product types
* Requires more classes and interfaces

---

## Real-World Examples

* UI toolkits (Windows / Mac themes)
* Database drivers (MySQL / Oracle)
* Cross-platform frameworks

---

## Summary

The **Abstract Factory Design Pattern** provides a structured way to create families of related objects while keeping client code independent from concrete implementations. It is especially useful when multiple product variants must work together consistently.

---

> **Factory Method → Creates one product**
> **Abstract Factory → Creates families
