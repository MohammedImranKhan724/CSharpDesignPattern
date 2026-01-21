# Singleton Design Pattern

## Definition

The **Singleton Design Pattern** ensures that a class has **only one instance** and provides a **global point of access** to that instance.

According to the Gang of Four (GoF):

> *Ensure a class only has one instance, and provide a global point of access to it.*

---

## Purpose

* Control access to shared resources
* Ensure a single instance throughout the application
* Reduce memory usage

---

## When to Use

* Logging services
* Application configuration
* Database connection manager
* Caching services

---

## Structure

### Key Characteristics

* Private constructor
* Static instance variable
* Public static method to get the instance

```text
class Singleton {
    private static Singleton instance;

    private Singleton() {}

    public static Singleton getInstance() {
        if (instance == null) {
            instance = new Singleton();
        }
        return instance;
    }
}
```

---

## Types of Singleton

* Lazy Initialization
* Eager Initialization
* Thread-safe Singleton
* Double-checked locking

---

## Advantages

* Controlled access to a single instance
* Reduced memory footprint
* Easy to access globally

---

## Disadvantages

* Difficult to unit test
* Can introduce global state
* Not suitable for all scenarios

---

## Real-World Examples

* Logger
* Configuration Manager
* Thread Pool

---

## Summary

The **Singleton Design Pattern** is useful when exactly one object is needed to coordinate actions across the system.