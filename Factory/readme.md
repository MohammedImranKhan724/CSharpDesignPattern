# Factory Design Pattern

## Definition

The **Factory Design Pattern** defines an interface for creating objects, but allows subclasses or a factory class to decide which class to instantiate.

According to the Gang of Four (GoF):

> *Define an interface for creating an object, but let subclasses decide which class to instantiate.*

---

## Purpose

* Encapsulate object creation logic
* Promote loose coupling
* Improve code readability and maintainability

---

## When to Use

* Object creation logic is complex
* The exact type of object is decided at runtime
* Client code should not depend on concrete classes

---

## Components

### 1. Product

Defines the interface for objects the factory will create.

```text
interface Product
```

---

### 2. ConcreteProduct

Implements the Product interface.

```text
class ConcreteProductA implements Product
class ConcreteProductB implements Product
```

---

### 3. Factory

Contains the logic to create and return product objects.

```text
class ProductFactory {
    Product createProduct(String type) {
        if (type == "A") return new ConcreteProductA();
        if (type == "B") return new ConcreteProductB();
        return null;
    }
}
```

---

## Advantages

* Centralized object creation
* Reduced coupling
* Easy to extend and maintain

---

## Disadvantages

* Factory can become complex
* Adding new products may require modifying the factory

---

## Real-World Examples

* Notification services (Email/SMS)
* Payment gateways
* Shape or document creation

---

## Summary

The **Factory Design Pattern** simplifies object creation and helps build flexible and maintainable systems by separating creation logic from usage.